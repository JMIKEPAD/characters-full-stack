using Microsoft.Data.Sqlite;

namespace Database.Services
{
    public class DatabaseService
    {
        private readonly string _dbPath;

        public DatabaseService()
        {
            // qui metti il path del tuo .db
            _dbPath = "/workspaces/characters-full-stack/backend/CharactersApi/db/movie.db";
        }

        public void GetTables()
        {
            using var connection = new SqliteConnection($"Data Source={_dbPath}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT * 
                FROM Movies
            ";
            Console.WriteLine("test", command);
            using var reader = command.ExecuteReader();

            Console.WriteLine("Tabelle nel database:");

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)}  ");
                }
                Console.WriteLine();
            }
        }
    }
}