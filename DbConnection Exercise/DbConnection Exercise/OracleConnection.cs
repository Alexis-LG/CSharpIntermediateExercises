using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection_Exercise
{
    abstract class OracleConnection : DbConnection
    {
        protected OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection has been opened.");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle Connection has been closed.");
        }
    }
}
