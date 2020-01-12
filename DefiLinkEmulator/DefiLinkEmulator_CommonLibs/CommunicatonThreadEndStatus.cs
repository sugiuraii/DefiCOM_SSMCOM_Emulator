using System;

namespace DefiLinkEmulator.Common
{
    public class CommunicationThreadEndStatus
    {
        public readonly boolean IsErrorOccured;
        public readonly Exception Exception;

        public CommunicationThreadEndStatus(bool isErrorOccured, Exception exception)
        {
            IsErrorOccured = isErrorOccured;
            Exception = exception;
        }
    }
}