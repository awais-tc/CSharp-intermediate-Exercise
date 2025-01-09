using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class DbCommand
    {
        public DbCommand(DbConnection db)
        {
            if (db == null)
                throw new InvalidOperationException("Connection cannot be null.");
            return;
        }
        public void Execute(string command)
        {
            Console.WriteLine("Executing command: " + command);
        }

    }
}
