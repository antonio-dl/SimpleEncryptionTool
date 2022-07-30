using UNIBO.SET.Model;

namespace Services.Cifratori
{
    public interface ICifratore
    {
        public FileCifrato CifraFile(Model.File file);
    }
}