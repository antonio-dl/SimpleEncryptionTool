using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.ModelLog
{
    // TODO: Completare il modello
    public abstract class Log : IEnumerable<Entry>
    {
        protected Entry[] Entries { get; set; }

        public IEnumerator<Entry> GetEnumerator()
        {
            return ((IEnumerable<Entry>)Entries).GetEnumerator();
        }

        public virtual void AddEntry(Entry entry)
        {
             Entries.Append(entry);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Entries.GetEnumerator();
        }
        public abstract void Save();
    }

    public enum EntryType
    {
        Info,
        Operazione,
        Avvertimento,
        Errore

    }


    public class Entry {
        DateTime Timestamp { get; }
        EntryType Type { get; }
        string Fonte { get; }
        string Message { get; }

        public Entry(EntryType type, string fonte, string message)
        {
            Timestamp = DateTime.Now;

            Type = type;
            Fonte = fonte;
            Message = message;
        }
    }
}
