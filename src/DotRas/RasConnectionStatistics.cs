﻿using System;

namespace DotRas
{
    /// <summary>
    /// Represents connection link statistics for a remote access connection.
    /// </summary>
    public class RasConnectionStatistics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RasConnectionStatistics"/> class.
        /// </summary>
        /// <param name="bytesTransmitted">The number of bytes transmitted.</param>
        /// <param name="bytesReceived">The number of bytes received.</param>
        /// <param name="framesTransmitted">The number of frames transmitted.</param>
        /// <param name="framesReceived">The number of frames received.</param>
        /// <param name="crcError">The number of cyclic redundancy check (CRC) errors that have occurred.</param>
        /// <param name="timeoutError">The number of timeout errors that have occurred.</param>
        /// <param name="alignmentError">The number of alignment errors that have occurred.</param>
        /// <param name="hardwareOverrunError">The number of hardware overrun errors that have occurred.</param>
        /// <param name="framingError">The number of framing errors that have occurred.</param>
        /// <param name="bufferOverrunError">The number of buffer overrun errors that have occurred.</param>
        /// <param name="compressionRatioIn">The compression ratio for data received on this connection or link.</param>
        /// <param name="compressionRatioOut">The compression ratio for data transmitted on this connection or link.</param>
        /// <param name="linkSpeed">The speed of the link, in bits per second.</param>
        /// <param name="connectionDuration">The length of time that the connection has been connected.</param>
        public RasConnectionStatistics(long bytesTransmitted, long bytesReceived, long framesTransmitted, long framesReceived, long crcError, long timeoutError, long alignmentError, long hardwareOverrunError, long framingError, long bufferOverrunError, long compressionRatioIn, long compressionRatioOut, long linkSpeed, TimeSpan connectionDuration)
        {
            BytesTransmitted = bytesTransmitted;
            BytesReceived = bytesReceived;
            FramesTransmitted = framesTransmitted;
            FramesReceived = framesReceived;
            CrcError = crcError;
            TimeoutError = timeoutError;
            AlignmentError = alignmentError;
            HardwareOverrunError = hardwareOverrunError;
            FramingError = framingError;
            BufferOverrunError = bufferOverrunError;
            CompressionRatioIn = compressionRatioIn;
            CompressionRatioOut = compressionRatioOut;
            LinkSpeed = linkSpeed;
            ConnectionDuration = connectionDuration;
        }

        protected RasConnectionStatistics()
        {
        }

        /// <summary>
        /// Gets the number of bytes transmitted.
        /// </summary>
        public virtual long BytesTransmitted { get; }

        /// <summary>
        /// Gets the number of bytes received.
        /// </summary>
        public virtual long BytesReceived { get; }

        /// <summary>
        /// Gets the number of frames transmitted.
        /// </summary>
        public virtual long FramesTransmitted { get; }

        /// <summary>
        /// Gets the number of frames received.
        /// </summary>
        public virtual long FramesReceived { get; }

        /// <summary>
        /// Gets the number of cyclic redundancy check (CRC) errors that have occurred.
        /// </summary>
        public virtual long CrcError { get; }

        /// <summary>
        /// Gets the number of timeout errors that have occurred.
        /// </summary>
        public virtual long TimeoutError { get; }

        /// <summary>
        /// Gets the number of alignment errors that have occurred.
        /// </summary>
        public virtual long AlignmentError { get; }

        /// <summary>
        /// Gets the number of hardware overrun errors that have occurred.
        /// </summary>
        public virtual long HardwareOverrunError { get; }

        /// <summary>
        /// Gets the number of framing errors that have occurred.
        /// </summary>
        public virtual long FramingError { get; }

        /// <summary>
        /// Gets the number of buffer overrun errors that have occurred.
        /// </summary>
        public virtual long BufferOverrunError { get; }

        /// <summary>
        /// Gets the compression ratio for data received on this connection or link.
        /// </summary>
        /// <remarks>This member is valid only for a single link connection, or a single link in a multilink connection.</remarks>
        public virtual long CompressionRatioIn { get; }

        /// <summary>
        /// Gets the compression ratio for data transmitted on this connection or link.
        /// </summary>
        /// <remarks>This member is valid only for a single link connection, or a single link in a multilink connection.</remarks>
        public virtual long CompressionRatioOut { get; }

        /// <summary>
        /// Gets the speed of the link, in bits per second.
        /// </summary>
        public virtual long LinkSpeed { get; }

        /// <summary>
        /// Gets the length of time that the connection has been connected.
        /// </summary>
        public virtual TimeSpan ConnectionDuration { get; }
    }
}