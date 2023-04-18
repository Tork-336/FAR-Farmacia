using System;
using System.Data;
using MySqlConnector;


namespace Data.Providers
{
	public class ProvidersRepository
	{
        // Listar los proveedores
        public DataSet list()
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procSelectProvider"; // Nombre del procedimineto
                sqlCommand.CommandType = CommandType.StoredProcedure;
                objAdapter.SelectCommand = sqlCommand;
                objAdapter.Fill(data);
            }
            connection.CloseConnection();
            return data;
        }

        // Pasar los datos a actualizar de proveedores
        public bool update(int id_provider, int nit_provider, string name_provider, string city_provider)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procUpdateShipping";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("id_provider", MySqlDbType.Int24).Value = id_provider;
                sqlCommand.Parameters.Add("nit_provider", MySqlDbType.Int24).Value = nit_provider;
                sqlCommand.Parameters.Add("name_provider", MySqlDbType.Text).Value = name_provider;
                sqlCommand.Parameters.Add("city_provider", MySqlDbType.Text).Value = city_provider;
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

        // Crear nuevo proveedor
        public bool insert(int nit_provider, string name_provider, string city_provider)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procInsertProvider";
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("nit_provider", MySqlDbType.Int24).Value = nit_provider;
                sqlCommand.Parameters.Add("name_provider", MySqlDbType.Text).Value = name_provider;
                sqlCommand.Parameters.Add("city_provider", MySqlDbType.Text).Value = city_provider;
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

        // Eliminar un proveedor
        public bool delete(int id_provider)
        {
            ConnectionBD connection = new ConnectionBD();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            if (connection.OpenConnection())
            {
                MySqlDataAdapter objAdapter = new MySqlDataAdapter();
                MySqlCommand sqlCommand = new MySqlCommand();

                sqlCommand.CommandText = "procDeleteProvider"; // Nombre del procedimineto
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("id_provider", MySqlDbType.Int24).Value = id_provider;
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

