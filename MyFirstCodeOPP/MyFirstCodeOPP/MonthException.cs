using System;
using System.Runtime.Serialization;

namespace MyFirstCodeOPP
{
    [Serializable]
    internal class MotnhException : Exception
    {
        public MotnhException()
        {
        }

        public MotnhException(string message) : base(message)
        {
        }

        public MotnhException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MotnhException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}