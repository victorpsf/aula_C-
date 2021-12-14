using MySql.Data.MySqlClient;

namespace Aula.Data
{
    public class DbExecutor : DbConnection
    {
        public DbExecutor() : base() {}


        private MySqlCommand PrepareCommand(string query, DbDynamicParameter? parameter) {
            MySqlCommand command = new MySqlCommand(query, this.connection);

            if (parameter != null) {
                parameter.SetParameters(command);
            }

            return command;
        }

        public MySqlDataReader ExecuteQuery(string query, DbDynamicParameter parameter) {
            MySqlCommand command = this.PrepareCommand(query, parameter);
            return command.ExecuteReader();
        }

        public MySqlDataReader ExecuteQuery(string query) {
            MySqlCommand command = this.PrepareCommand(query, null);
            return command.ExecuteReader();
        }
    }
}