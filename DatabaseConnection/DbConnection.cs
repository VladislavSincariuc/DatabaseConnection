using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Database cannot have a null or empty Connection String");
 
            _connectionString = connectionString;
        }
 
        public abstract void Open();
 
        public abstract void Close();
 
        private void CheckConnectionTime()
        {
            // Implementation if there was a connection:
 
            //if (_timeout > connectionTime)
            //    throw new TimeoutException("Connection failure, time out!");
        }
    }

    }
