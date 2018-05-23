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
            var dbCommand = new DbCommand("SELECT * FROM DATA", sqlConnection);
            dbCommand.Execute();
        }
    }
}
