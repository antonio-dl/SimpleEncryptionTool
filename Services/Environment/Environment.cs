namespace UNIBO.SET
{
    public class SETEnvironment
    {
        public static readonly string Configuration_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET", "settings.json");
        public static readonly string Credential_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET", "cred.bin");
        public static readonly string Log_Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET", "logs");

    }
}