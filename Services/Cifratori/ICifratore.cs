using System.Runtime.Serialization;
using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Cifratori
{
    public interface ICifratore
    {
        public Key CifraFile(UNIBO.SET.Model.File file);

        public string Algoritmo { get; }
    }
}

[Serializable]
public class SalveKeyException : Exception
{
    public SalveKeyException()
    {
    }

    public SalveKeyException(string? message) : base(message)
    {
    }

    public SalveKeyException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected SalveKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}