using System;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        // This method doesn’t have a body.
        public abstract Draw();
    }
}