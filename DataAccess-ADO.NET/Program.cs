using Microsoft.Data.SqlClient;
using System;

namespace DataAccess_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //windows authentication "Server=localhost,1433;Database=meubanco;Integrated Security=SSPI"
            const string connectionString = "Server=localhost,1433;Database=meubanco;User ID=user;Password=senha";

            //var connection = new SqlConnection();
            //connection.Open();
            //connection.Close();
            //connection.Dispose();

            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectado!");
            }
        }
    }
}
