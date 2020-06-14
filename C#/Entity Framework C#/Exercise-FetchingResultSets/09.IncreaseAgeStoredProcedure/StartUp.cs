﻿using System;
using System.Data.SqlClient;

namespace _09.IncreaseAgeStoredProcedure
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int birthdayMinionId = int.Parse(Console.ReadLine());

            var connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=MinionsDB;Integrated Security=True");
            connection.Open();

            using (connection)
            {
                string cmdText = "EXEC usp_GetOlder @id";
                var command = new SqlCommand(cmdText, connection);
                command.Parameters.AddWithValue("@id", birthdayMinionId);
                command.ExecuteNonQuery();

                string printQuery = "SELECT Name, Age FROM Minions WHERE Id = @id";
                var printCommand = new SqlCommand(printQuery, connection);
                printCommand.Parameters.AddWithValue("id", birthdayMinionId);
                var printer = printCommand.ExecuteReader();

                printer.Read();
                string minionName = (string)printer["Name"];
                int age = (int)printer["Age"];
                printer.Close();

                Console.WriteLine($"{minionName} - {age} years old");
            }
        }
    }
}
