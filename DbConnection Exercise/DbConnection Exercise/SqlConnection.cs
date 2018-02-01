using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection_Exercise
{
    abstract class SqlConnection : DbConnection
    {
        protected SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection has been opened.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL Connection has been closed.");
        }
    }

}
