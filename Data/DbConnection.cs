using MySql.Data.MySqlClient;

namespace Aula.Data
{
    public class DbConnection
    {
        private string connectionString = "Server=localhost;Database=APP_TERMINAL;Uid=APP;Pwd=QKgv/4SD+rKeUVvCBLx/4Wc2+JBYKvrc/GCipcC70Z4=;";
        protected MySqlConnection connection;

        public DbConnection() {
            this.connection = new MySqlConnection(this.connectionString);
        }

        public void Open() {
            this.connection.Open();
        }

        public void Close() {
            this.connection.Close();
        }
    }
}