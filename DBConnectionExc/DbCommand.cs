using System;

namespace DBConnectionExc
{
    public class DbCommand
    {
        public string _command { get; set; }
        public DbConnection _dbConnection { get; set; } 

        public DbCommand(string command, DbConnection dbConnection)
        {
            if (dbConnection == null || command == null || String.IsNullOrWhiteSpace(command))
            {
                throw new InvalidOperationException("Invalid db connection");
            }
            else
            {
                _command = command;
                _dbConnection = dbConnection;
            }
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("The command {0} has been executed on {1}",_command,_dbConnection._connectionString);
            _dbConnection.Close();
        }

    }
}
