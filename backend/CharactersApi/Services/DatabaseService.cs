using Microsoft.Data.Sqlite;

namespace Database.Services
{
    public class DatabaseService
    {
        private readonly string _dbPath;

        public DatabaseService()
        {
            // qui metti il path del tuo .db
            _dbPath = "/workspaces/characters-full-stack/backend/CharactersApi/database.db";
        }

        public void GetTables()
        {
            using var connection = new SqliteConnection($"Data Source={_dbPath}");
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT * 
                FROM Characters
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
        private void readerDB(){
            using var connection = new SqliteConnection($"Data Source={_dbPath}");
            var command = connection.CreateCommand();

            command.CommandText =
            @"
            SELECT name 
            FROM sqlite_master 
            WHERE type='table';
            ";

            using var reader = command.ExecuteReader();

            var tables = new List<string>();

            while (reader.Read())
            {
                tables.Add(reader.GetString(0));
            };
            foreach (var table in tables)
            {
                Console.WriteLine($"\n--- Tabella: {table} ---");

                var columnCommand = connection.CreateCommand();
                columnCommand.CommandText = $"PRAGMA table_info({table})";

                using var columnReader = columnCommand.ExecuteReader();

                while (columnReader.Read())
                {
                    Console.WriteLine(
                        $"Colonna: {columnReader["name"]} | Tipo: {columnReader["type"]}"
                    );
                }
            }
    }
    }
}
