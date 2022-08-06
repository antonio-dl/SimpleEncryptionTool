using UNIBO.SET.Model;

namespace Services.Cifratori
{
    public interface ICifratore
    {
        public FileCifrato CifraFile(UNIBO.SET.Model.File file);
    }
}