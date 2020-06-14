using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _07.PrintAllMinionNames
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var minions = new List<string>();

            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True");
            connection.Open();

            using (connection)
            {
                string commandText = "SELECT Name FROM Minions";
                SqlCommand command = new SqlCommand(commandText, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    minions.Add(name);
                }

                reader.Close();

                int counter = minions.Count;
                int loopEnd = minions.Count / 2;

                for (int i = 0; i < loopEnd; i++)
                {
                    Console.WriteLine(minions[i]);
                    Console.WriteLine(minions[counter - i - 1]);
                }

                if (counter % 2 == 1)
                {
                    Console.WriteLine(minions[minions.Count / 2]);
                }
            }
        }
    }
}
