using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override TimeSpan Timeout
        {
            get { return TimeSpan.FromMinutes(2); }
        }
        public override void Open()
        {
            Console.WriteLine("SQL Connection is open.");
        }
        public override void Close()
        {
            Console.WriteLine("SQL Connection is closed.");
        }
    }
}
