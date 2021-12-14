using MySql.Data.MySqlClient;
using System.Data;

namespace Aula.Data
{
    public class DbDynamicParameter
    {
        private List<MySqlParameter> parameters;

        public DbDynamicParameter() {
            this.parameters = new List<MySqlParameter>();
        }

        private void Add (MySqlParameter parameter) {
            this.parameters.Add(parameter);
        }

        public DbDynamicParameter Add(string name, object value) {
            MySqlParameter parameter = new MySqlParameter();

            parameter.ParameterName = name;
            parameter.Value = value;

            this.Add(parameter);
            return this;
        }

        public DbDynamicParameter Add(string name, object value, ParameterDirection direction) {
            MySqlParameter parameter = new MySqlParameter();

            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.Direction = direction;

            this.Add(parameter);
            return this;
        }

        public DbDynamicParameter Add(string name, object value, ParameterDirection direction, MySqlDbType type) {
            MySqlParameter parameter = new MySqlParameter();

            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.Direction = direction;
            parameter.MySqlDbType = type;

            this.Add(parameter);
            return this;
        }

        public DbDynamicParameter Add(string name, object value, MySqlDbType type) {
            MySqlParameter parameter = new MySqlParameter();

            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.MySqlDbType = type;

            this.Add(parameter);
            return this;
        }

        public void SetParameters(MySqlCommand command) {
            command.Parameters.AddRange(this.parameters.ToArray());
        }
    }
}