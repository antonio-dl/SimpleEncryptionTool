using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Decifratori
{
    internal class DecifratoreTestNonDecifratore : IDecifratore
    {
        public string Algoritmo => "NessunAlgoritmo";

        public FileDecifrato Decifra(Key key)
        {
            return null;
        }
    }
}