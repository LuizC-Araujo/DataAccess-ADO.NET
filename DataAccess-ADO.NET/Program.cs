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
                connection.Open();

                using(var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "SELECT [Id], [Title] FROM [Category]";

                    //command.ExecuteNonQuery(); para não leitura
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");
                    }

                }
            }
        }
    }
}
