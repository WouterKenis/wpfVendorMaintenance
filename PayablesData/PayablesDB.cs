using System.Data.SqlClient;

namespace PayablesData
{
    internal static class PayablesDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Payables;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
