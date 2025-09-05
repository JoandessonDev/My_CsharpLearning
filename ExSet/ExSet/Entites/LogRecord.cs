using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExSet.Entites
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instat { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            LogRecord other = obj as LogRecord;

            return Username.Equals(other);



        }
    }
}
