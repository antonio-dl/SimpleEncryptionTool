using UNIBO.SET.Model;

namespace Services.Decifratori
{
    public interface IDecifratore
    {
        FileDecifrato Decifra(Key key);
        string Algoritmo { get; }
    }
}
