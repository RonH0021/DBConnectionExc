using System;

namespace DBConnectionExc
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("The connection to Oracle has been opened with connection string {0}", _connectionString);
        }

        public override void Close()
        {
            Console.WriteLine("The connection to Oracle has been closed with connection string {0}", _connectionString);
        }
    }
}
