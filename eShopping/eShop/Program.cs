using Microsoft.Data.SqlClient;
using System.Globalization;
using System.Text;

namespace eShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=eShopping;Trusted_Connection=True;TrustServerCertificate=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                Console.WriteLine("Dataya qoşulur...\n");

                try
                {
                    string query = "SELECT ProductId, ProductName, ProductPrice, ProductDescription FROM Products";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productId = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                decimal price = reader.GetDecimal(2);
                                string description = reader.GetString(3);
                                Console.WriteLine($"Product Id: {productId}\nProduct Name: {name}\nProduct Price: {price}\nTest description: {description}\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}