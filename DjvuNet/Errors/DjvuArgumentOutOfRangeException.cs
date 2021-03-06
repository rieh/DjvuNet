﻿using System;

namespace DjvuNet.Errors
{
    [Serializable]
    public class DjvuArgumentOutOfRangeException : ArgumentOutOfRangeException
    {
        public DjvuArgumentOutOfRangeException() : base()
        {
        }

        public DjvuArgumentOutOfRangeException(string paramName) : base(paramName)
        {
        }

        public DjvuArgumentOutOfRangeException(string message, Exception innerException) : base (message, innerException)
        {
        }

        public DjvuArgumentOutOfRangeException(string paramName, string message) : base (paramName, message)
        {
        }

        public DjvuArgumentOutOfRangeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base (info, context)
        {
        }

        public DjvuArgumentOutOfRangeException(string paramName, object actualValue, string message)
            : base(paramName, actualValue, message)
        {
        }
    }
}
