using System;
using System.Runtime.Serialization;

namespace _02_Exception
{
    [Serializable]
    internal class Format : Exception
    {
        public Format()
        {
        }

        public Format(string message) : base(message)
        {
        }

        public Format(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Format(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}