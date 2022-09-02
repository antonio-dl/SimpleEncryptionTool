using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Cifratori
{
    public interface ICifratore
    {
        public FileCifrato CifraFile(UNIBO.SET.Model.File file);

        public string Algoritmo { get; }
    }
}