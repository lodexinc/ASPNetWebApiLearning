using Npgsql;

namespace ASPNetWebApiLearning.Data.PostgreSQL
{
    public class PostgreSQLRepository
    {
        public PostgreSQLRepository()
        {
            string connectionString = "";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
        }
    }
}
