using System;
using System.Data.SqlClient;

namespace _03.MinionNames
{
    public class StartUp
    {

        private static string connectionString =
            "Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=true";

        private static SqlConnection connection = new SqlConnection(connectionString);
        public static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());

            connection.Open();

            using (connection)
            {
                string queryText = @"SELECT Name FROM Villains WHERE Id = @Id";

                SqlCommand command = new SqlCommand(queryText, connection);
                command.Parameters.AddWithValue("@Id", id);

                object result = command.ExecuteScalar();

                if (String.IsNullOrWhiteSpace((string)result))
                {
                    Console.WriteLine($"No villain with ID {id} exists in the database.");
                    return;
                }

                Console.WriteLine($"Villain: {(string)result}");

                queryText = @"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = @Id
                                ORDER BY m.Name";

                command = new SqlCommand(queryText, connection);
                command.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows == false)
                {
                    Console.WriteLine("(no minions)");
                }
                else
                {
                    using (reader)
                    {
                        int counter = 1;

                        while(reader.Read())
                        {
                            Console.WriteLine($"{counter}. {reader["Name"]} {reader["Age"]}");
                            counter++;
                        }
                    }
                }
            }
        }
    }
}
