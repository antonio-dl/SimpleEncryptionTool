using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIBO.SET.ModelLog
{
    // TODO: Completare il modello
    public abstract class Log
    {
        protected Entry[] Entries { get; set; } = new Entry[0];

        public virtual void AddEntry(Entry entry)
        {
            Entries.Append(entry);
        }

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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(this.Timestamp.ToString("MM/dd/yyyy HH:mm:ss:ff"));
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
