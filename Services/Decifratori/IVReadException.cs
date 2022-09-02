using System.Runtime.Serialization;

namespace UNIBO.SET.Services.Decifratori
{
    [Serializable]
    internal class IVReadException : Exception
    {
        public IVReadException()
        {
        }

        public IVReadException(string? message) : base(message)
        {
        }

        public IVReadException(string? message, Exception? innerException) : base(message, innerException)
        {
        }


        protected IVReadException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}