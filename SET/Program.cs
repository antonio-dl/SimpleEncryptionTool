

using Services.Presenters;

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
            Inizializzatore init = InizializzaPresenters();
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeSET(init));
        }

        private static Inizializzatore InizializzaPresenters()
        {
            throw new NotImplementedException();
        }
    }
}