using System.Data;
using Npgsql;

namespace test_project_api.Entity
{
    public class DatabaseContext
    {
        public static IDbConnection Instance
        {
            get
            {
                var connStringBuilder = new NpgsqlConnectionStringBuilder();
                connStringBuilder.Host = "localhost";
                connStringBuilder.Port = 5432;
                connStringBuilder.Username = "postgres";
                connStringBuilder.Password = "postgres";
                connStringBuilder.Database = "test_project";

                var connString = connStringBuilder.ConnectionString;

                var connection = new NpgsqlConnection(connString);

                return connection;
            }
        }
    }
}

