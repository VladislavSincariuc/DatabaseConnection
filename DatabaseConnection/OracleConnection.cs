using System;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Here is done the String Connection to Sql!!{0}", connectionString);
        }

        public override void Open()
        {
            Console.WriteLine("Open a Connection to a Oracle Server");
        }

        public override void Close()
        {
            Console.WriteLine("Close a Connection to a Sql Server");
        }
    }
}