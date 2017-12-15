using System;

namespace BridgeTechWhizz
{
    public class MainApp
    {

        // Client program
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Database Connection");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. OleDb Database");
                Console.WriteLine("2. Sql server Database");
                Console.Write("Enter choice:");
                var input = Console.ReadLine();
                IDatabase database = DatabaseFactory.GetDatabaseObject(input); // Main Factory provides the database object
                if (database == null)
                {
                    Console.WriteLine("Invalid choice. Press any key to exit");
                    Console.ReadKey();
                    break;
                }
                database.PrintConnection();
                Console.Write("\n\n");
            }
        }
    }
}

