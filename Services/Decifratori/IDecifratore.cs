using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    public interface IDecifratore
    {
        public FileDecifrato Decifra(Key key);
        public string Algoritmo { get; }
    }
}
