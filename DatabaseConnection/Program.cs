namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracle = new OracleConnection("go");
            oracle.Open();
            

            var sql = new SqlConnection("go");
            sql.Open();
            sql.Close();


           
        }
    }
}