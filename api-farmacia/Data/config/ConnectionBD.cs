using MySql.Data.MySqlClient;

namespace Data;

public class ConnectionBD
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;
    
    public ConnectionBD()
    {
        Initialize();
    }
    
    private void Initialize()
    {
        server = "localhost";
        database = "mydb";
        uid = "username";
        password = "password";
        string connectionString;
        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
                           database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        this.connection = new MySqlConnection(connectionString);
    }
    
    private bool OpenConnection()
    {
        try
        {
            this.connection.Open();
            return true;
        }
        catch (MySqlException ex)
        {
            switch (ex.Number)
            {
                case 0:
                    Console.WriteLine("Cannot connect to server.  Contact administrator");
                    break;

                case 1045:
                    Console.WriteLine("Invalid username/password, please try again");
                    break;
            }
            return false;
        }
    }
    
    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
    }
}