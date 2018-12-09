﻿using System;
using System.Net;
using DotRas.Internal.Abstractions.Factories;
using DotRas.Internal.Abstractions.Policies;
using DotRas.Internal.Abstractions.Services;
using DotRas.Win32;
using static DotRas.Win32.NativeMethods;
using static DotRas.Win32.Ras;
using static DotRas.Win32.WinError;

namespace DotRas.Internal.Services
{
    internal class RasGetCredentials : IRasGetCredentials
    {
        private readonly IRasApi32 api;
        private readonly IStructFactory structFactory;
        private readonly IExceptionPolicy exceptionPolicy;

        public RasGetCredentials(IRasApi32 api, IStructFactory structFactory, IExceptionPolicy exceptionPolicy)
        {
            this.api = api ?? throw new ArgumentNullException(nameof(api));
            this.structFactory = structFactory ?? throw new ArgumentNullException(nameof(structFactory));
            this.exceptionPolicy = exceptionPolicy ?? throw new ArgumentNullException(nameof(exceptionPolicy));
        }

        public NetworkCredential GetNetworkCredential(string entryName, string phoneBookPath)
        {
            if (string.IsNullOrWhiteSpace(entryName))
            {
                throw new ArgumentNullException(nameof(entryName));
            }
            else if (string.IsNullOrWhiteSpace(phoneBookPath))
            {
                throw new ArgumentNullException(nameof(phoneBookPath));
            }

            var rasCredentials = CreateStructure(RASCM.UserName | RASCM.Password | RASCM.Domain);

            var ret = api.RasGetCredentials(phoneBookPath, entryName, ref rasCredentials);
            if (ret != SUCCESS)
            {
                throw exceptionPolicy.Create(ret);
            }

            return new NetworkCredential(
                rasCredentials.szUserName,
                rasCredentials.szPassword,
                rasCredentials.szDomain);
        }

        private RASCREDENTIALS CreateStructure(RASCM mask)
        {
            var rasCredentials = structFactory.Create<RASCREDENTIALS>();
            rasCredentials.dwMask = mask;

            return rasCredentials;
        }
    }
}