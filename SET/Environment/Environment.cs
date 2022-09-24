namespace UNIBO.SET
{
    internal class SETEnvironment
    {
        public static readonly string Configuration_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET", "settings.json");
        public static readonly string Credential_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SET", "cred.bin");
    }
}