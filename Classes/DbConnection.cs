using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal abstract class DbConnection
    {
        string _connectionString;
        TimeSpan _timeout;
        public abstract TimeSpan Timeout { get; }
        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty.");
            _connectionString = connectionString;
            return;
        }
        public abstract void Open();
        public abstract void Close(); 
        

    }
}
