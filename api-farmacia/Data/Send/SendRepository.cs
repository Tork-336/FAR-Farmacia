using System.Data;
using MySql.Data.MySqlClient;

namespace Data.envios;

public class SendRepository
{
    // Listar los envios
    public DataSet list()
    {
        ConnectionBD connection = new ConnectionBD();
        DataSet data = new DataSet();
        if (connection.OpenConnection())
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand();

            sqlCommand.CommandText = "procSelectShipping"; // Nombre del procedimineto
            sqlCommand.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = sqlCommand;
            objAdapter.Fill(data);
        }
        connection.CloseConnection();
        return data;
    }

    // Pasar los datos a actualizar del envio
    public bool update(int id_shipping, int number_shipping, string address_shipping, int phone_shipping, int id_driver)
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
            sqlCommand.Parameters.Add("id_shipping", MySqlDbType.Int24).Value = id_shipping;
            sqlCommand.Parameters.Add("number_shipping", MySqlDbType.Int24).Value = number_shipping;
            sqlCommand.Parameters.Add("address_shipping", MySqlDbType.Text).Value = address_shipping;
            sqlCommand.Parameters.Add("phone_shipping", MySqlDbType.Int24).Value = phone_shipping;
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
    
    // Crear nuevo envio
    public bool insert(int number_shipping, string address_shipping, int phone_shipping, int id_driver)
    {
        ConnectionBD connection = new ConnectionBD();
        DataSet data = new DataSet();
        int row = 0;
        bool executed = false;
        if (connection.OpenConnection())
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand();

            sqlCommand.CommandText = "procInsertShipping";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("number_shipping", MySqlDbType.Int24).Value = number_shipping;
            sqlCommand.Parameters.Add("address_shipping", MySqlDbType.Text).Value = address_shipping;
            sqlCommand.Parameters.Add("phone_shipping", MySqlDbType.Int24).Value = phone_shipping;
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
    
    // Eliminar un envio
    public bool delete(int id_shipping)
    {
        ConnectionBD connection = new ConnectionBD();
        DataSet data = new DataSet();
        int row = 0;
        bool executed = false;
        if (connection.OpenConnection())
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            MySqlCommand sqlCommand = new MySqlCommand();

            sqlCommand.CommandText = "procDeleteShipping"; // Nombre del procedimineto
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("id_shipping", MySqlDbType.Int24).Value = id_shipping;
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