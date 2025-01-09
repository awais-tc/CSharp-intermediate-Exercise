using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }
        public override TimeSpan Timeout
        {
            get { return TimeSpan.FromMinutes(3); }
        }
        public override void Open()
        {
            Console.WriteLine("Oracle Connection is open.");
        }
        public override void Close()
        {
            Console.WriteLine("Oracle Connection is closed.");
        }
    }
}
