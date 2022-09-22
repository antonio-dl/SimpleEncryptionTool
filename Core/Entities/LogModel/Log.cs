using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.ModelLog
{
    public abstract class Log
    {
        protected Entry[] _entries = Array.Empty<Entry>();

        public virtual void AddEntry(Entry entry)
        {
            _entries.Append(entry);
        }
        public abstract Entry[] GetEntries();

        public abstract Entry[] GetEntries(EntryType filteredType);

    }

    public enum EntryType
    {
        Info,
        Operazione,
        Avvertimento,
        Errore

    }


    public class Entry
    {
        public DateTime Timestamp { get; }
        public EntryType Type { get; }
        public string Fonte { get; }
        public string Message { get; }

        public Entry(EntryType type, string fonte, string message)
        {
            Timestamp = DateTime.Now;

            Type = type;
            Fonte = fonte;
            Message = message;
        }

        public Entry(DateTime timestamp, EntryType type, string fonte, string message)
        {
            Timestamp = timestamp;
            Type = type;
            Fonte = fonte;
            Message = message;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.Timestamp.ToString("yyyy/MM/dd HH:mm:ss:ff"));
            result.Append(" | ");

            result.Append(this.Type.ToString());
            result.Append(" | ");

            result.Append(this.Fonte.ToString());
            result.Append(" | ");

            result.Append(this.Message.ToString());

            return result.ToString();
        }
    }
}
