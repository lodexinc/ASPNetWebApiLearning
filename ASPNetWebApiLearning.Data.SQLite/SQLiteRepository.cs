using Microsoft.Data.Sqlite;

namespace ASPNetWebApiLearning.Data.SQLite
{
    public class SQLiteRepository
    {
        public SQLiteRepository()
        {
            string connectionString = "";
            SqliteConnection connection = new SqliteConnection(connectionString);
        }
    }
}
