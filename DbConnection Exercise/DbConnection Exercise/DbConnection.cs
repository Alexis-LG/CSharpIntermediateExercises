using System;
using static System.String;

namespace DbConnection_Exercise
{
    public abstract class DbConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (IsNullOrEmpty(connectionString))
                throw new NullReferenceException("Connection String is empty");
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
