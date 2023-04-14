using MySql.Data.MySqlClient;

namespace Data.envios;

public class SendRepository
{
    public void list()
    {
        ConnectionBD connection = new ConnectionBD();

        if (connection.OpenConnection())
        {
            MySqlCommand sqlCommand = new MySqlCommand();

            sqlCommand.CommandText("call ");
        }
    }
}