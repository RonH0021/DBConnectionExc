using System;

namespace DBConnectionExc
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("The connection to SQL has been opened with connection string {0}", _connectionString);
        }

        public override void Close()
        {
            Console.WriteLine("The connection to SQL has been closed with connection string {0}", _connectionString);
        }
    }
}
