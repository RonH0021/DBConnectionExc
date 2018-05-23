using System;

namespace DBConnectionExc
{
    public abstract class DbConnection
    {
        public string _connectionString { get; set; }
        public TimeSpan _timeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null || String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Invalid connection string");
            }
            else
            {
                _connectionString = connectionString;
            }
        }

        public abstract void Open();
        public abstract void Close();
        
    }
}
