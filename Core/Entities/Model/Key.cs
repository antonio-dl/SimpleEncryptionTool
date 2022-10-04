using System.Collections;

namespace UNIBO.SET.Model
{
    [Serializable]
    public record Key
    {
        public string Algoritmo { get; }
        public string TargetFilePath { get; }
        public string SourceFilePath { get; }
        public CodiceVerifica CodiceVerifica { get; }
        public byte[] Password { get; }

        public DateTime UltimaModifica { get; } // FIXME: Da aggiustare il costruttore, forse meglio utilizzare un'altra classe per contenere le cryptInfo

        public Key(string sourceFilePath, CodiceVerifica codiceVerifica, string targetFilePath, byte[]? password, string algoritmo)
        {
            SourceFilePath = sourceFilePath ?? throw new ArgumentNullException(nameof(sourceFilePath));
            TargetFilePath = targetFilePath ?? throw new ArgumentNullException(nameof(targetFilePath));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Algoritmo = algoritmo ?? throw new ArgumentNullException(nameof(algoritmo));
            CodiceVerifica = codiceVerifica ?? throw new ArgumentNullException(nameof(codiceVerifica));
        }
    }
    [Serializable]
    public abstract class KeyChain
    {
        protected IList<Key> _keylist ;

        public abstract void AddKey(Key key);
        public abstract IList<Key> GetAllKey();

        public abstract bool DeleteKey(Key key);

    }
    [Serializable]
    public class FileKeyChain : KeyChain
    {
        public string Name { get => Path.GetFileName(PathFileKeyChain); }
        public string PathFileKeyChain { get; }

        public FileKeyChain(string pathFileKeyChain)
        {
            PathFileKeyChain = pathFileKeyChain;
            this._keylist = new List<Key>();

        }

        public override void AddKey(Key key)
        {
            this._keylist.Add(key);
        }

        public override IList<Key> GetAllKey()
        {
            return this._keylist;
        }

        public override bool DeleteKey(Key key)
        {
            return this._keylist.Remove(key);
        }
    }
}