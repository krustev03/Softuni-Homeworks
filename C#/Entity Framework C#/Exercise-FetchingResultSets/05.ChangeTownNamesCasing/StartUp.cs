using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _05.ChangeTownNamesCasing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True");

            connection.Open();

            string countryName = Console.ReadLine();
            int countryId = 0;
            var townsInCountry = new List<string>();

            using (connection)
            {
                string commandText = "SELECT c.Id FROM Countries AS c WHERE c.Name = @countryName";
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@countryName", countryName);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    countryId = (int)reader["Id"];
                }

                reader.Close();

                commandText = "UPDATE Towns SET Name = UPPER(Name) WHERE CountryCode = @countryCode";
                command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@countryCode", countryId);
                int rowsAffected = command.ExecuteNonQuery();

                commandText = "SELECT Name FROM Towns WHERE CountryCode = @countryCode";
                command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@countryCode", countryId);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string town = (string)reader["Name"];
                    townsInCountry.Add(town);
                }

                if (townsInCountry.Count > 0)
                {
                    Console.WriteLine($"{townsInCountry.Count} town names were affected.");
                    Console.WriteLine($"[{String.Join(", ", townsInCountry)}]");
                }
                else
                {
                    Console.WriteLine("No town names were affected.");
                }
            }
        }
    }
}
