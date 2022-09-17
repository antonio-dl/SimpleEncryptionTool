using UNIBO.SET.Model;

namespace UNIBO.SET.Services.Cifratori
{
    public interface ICifratore
    {
        public Key CifraFile(UNIBO.SET.Model.File file);

        public string Algoritmo { get; }
    }
}