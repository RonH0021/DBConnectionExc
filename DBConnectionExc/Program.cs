using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExc
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("ACC_TST_CON");
            var sqlCommand = new DbCommand("SELECT * FROM DATA", sqlConnection);
            sqlCommand.Execute();

            var oracleConnection = new OracleConnection(@"IBM\DB2");
            var oracleCommand = new DbCommand("SELECT * FROM ITEMS", oracleConnection);
            oracleCommand.Execute();
        }
    }
}
