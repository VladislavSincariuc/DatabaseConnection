using System;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Here is done the String Connection to Sql!!{0}", connectionString);
        }

        public override void Open()
        {

            Console.WriteLine("Database was opened succesufule");
        }

        public override void Close()
        {
            Console.WriteLine("Close Connectionto a Database");
        }

        
    }
}