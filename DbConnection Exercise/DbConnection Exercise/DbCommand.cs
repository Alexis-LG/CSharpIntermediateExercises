using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection_Exercise
{
    class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection == null)
                throw new ArgumentException("Connection is null.");
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Invalid instruction, it must not be null, whitespace or empty.");
            _dbConnection = dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_instruction);
            _dbConnection.CloseConnection();
        }

    }
}
