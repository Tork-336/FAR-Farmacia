using System;
using MySqlConnector;
using System.Data;

namespace Data.Driver
{
	public class DriverRepository
	{
        // Listar los conductores
        public DataSet list()
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procSelectDriver"; // Nombre del procedimineto
                sqlCommand.CommandType = CommandType.StoredProcedure;
                objAdapter.SelectCommand = sqlCommand;
                objAdapter.Fill(data);
            }
            connection.CloseConnection();
            return data;
        }

        // Pasar los datos a actualizar de conductores
        public bool update(int id_driver, int identification_driver, string numberLicense_driver,
            string name_driver, string surname_driver, int phone_driver, int age_driver, char gender_driver,
            string typeLicense)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procUpdateDriver";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("id_driver", MySqlDbType.Int24).Value = id_driver;
                sqlCommand.Parameters.Add("identification_driver", MySqlDbType.Int24).Value = identification_driver;
                sqlCommand.Parameters.Add("numberLicense_driver", MySqlDbType.Text).Value = numberLicense_driver;
                sqlCommand.Parameters.Add("name_driver", MySqlDbType.Text).Value = name_driver;
                sqlCommand.Parameters.Add("surname_driver", MySqlDbType.Text).Value = surname_driver;
                sqlCommand.Parameters.Add("phone_driver", MySqlDbType.Int24).Value = phone_driver;
                sqlCommand.Parameters.Add("age_driver", MySqlDbType.Int24).Value = age_driver;
                sqlCommand.Parameters.Add("gender_driver", MySqlDbType.Text).Value = surname_driver;
                sqlCommand.Parameters.Add("typeLicense", MySqlDbType.Text).Value = typeLicense;
                objAdapter.SelectCommand = sqlCommand;
                objAdapter.Fill(data);
                row = sqlCommand.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            connection.CloseConnection();
            return executed;
        }

        // Crear nuevo conductor
        public bool insert(int identification_driver, string numberLicense_driver,
            string name_driver, string surname_driver, int phone_driver, int age_driver, char gender_driver,
            string typeLicense)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procInsertDriver";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("identification_driver", MySqlDbType.Int24).Value = identification_driver;
                sqlCommand.Parameters.Add("numberLicense_driver", MySqlDbType.Text).Value = numberLicense_driver;
                sqlCommand.Parameters.Add("name_driver", MySqlDbType.Text).Value = name_driver;
                sqlCommand.Parameters.Add("surname_driver", MySqlDbType.Text).Value = surname_driver;
                sqlCommand.Parameters.Add("phone_driver", MySqlDbType.Int24).Value = phone_driver;
                sqlCommand.Parameters.Add("age_driver", MySqlDbType.Int24).Value = age_driver;
                sqlCommand.Parameters.Add("gender_driver", MySqlDbType.Text).Value = surname_driver;
                sqlCommand.Parameters.Add("typeLicense", MySqlDbType.Text).Value = typeLicense;
                objAdapter.SelectCommand = sqlCommand;
                objAdapter.Fill(data);
                row = sqlCommand.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            connection.CloseConnection();
            return executed;
        }

        // Eliminar un conductor
        public bool delete(int id_driver)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procDeleteDriver"; // Nombre del procedimineto
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("id_driver", MySqlDbType.Int24).Value = id_driver;
                objAdapter.SelectCommand = sqlCommand;
                objAdapter.Fill(data);
                row = sqlCommand.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            connection.CloseConnection();
            return executed;
        }
    }
}

