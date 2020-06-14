using System;
using System.Data.SqlClient;

namespace _02.VillainNames
{
    public class StartUp
    {

        private static string connectionString = 
            "Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=true";

        private static SqlConnection connection = new SqlConnection(connectionString);

        public static void Main()
        {
            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True");

            connection.Open();

            using (connection)
            {
                string cmdText = "SELECT v.Name, COUNT(mv.MinionId) [Minions Count] " +
                                   "FROM Villains v " +
                                   "JOIN MinionsVillains mv ON mv.VillainId = v.Id " +
                                  "GROUP BY v.Name " +
                                 "HAVING COUNT(mv.MinionId) > 3 " +
                                  "ORDER BY [Minions Count] DESC";

                var command = new SqlCommand(cmdText, connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string villainName = (string)reader["Name"];
                    int minionsCount = (int)reader["Minions Count"];

                    Console.WriteLine($"{villainName} - {minionsCount}");
                }
            }
        }
    }
}
