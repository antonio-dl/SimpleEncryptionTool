using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    public interface IDecifratore
    {
        FileDecifrato Decifra(Key key);
        string Algoritmo { get; }
    }
}
