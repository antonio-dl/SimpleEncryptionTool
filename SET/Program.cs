

using UNIBO.SET.Services.Presenters;

namespace UNIBO.SET.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (PrimoAvvio())
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Forms.FirstLoginView()); // Da creare :D
            }
            else
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Forms.LoginView());
            }
        }

        private static bool PrimoAvvio()
        {
            // Se non esistono le impostazioni/dati utente -> true
            string path_to_credential = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET","cred.bin");
            if (File.Exists(path_to_credential))
                return false;
            return true;

        }
    }
}