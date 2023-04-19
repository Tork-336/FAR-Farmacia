using System.Data;
using Data.envios;

namespace Logic.Send;

// This class for implemention Send service
public class SendService
{
    private SendRepository _repository;

    // This method for list Send's
    public DataSet list()
    {
        return this._repository.list();
    }
    
    // This method for update Send
    public bool update(int id_shipping, int number_shipping, string address_shipping, int phone_shipping, int id_driver)
    {
        return this._repository.update(id_shipping, number_shipping, address_shipping, phone_shipping, id_driver);
    }
    
    // This method for insert new Send
    public bool insert(int number_shipping, string address_shipping, int phone_shipping, int id_driver)
    {
        return this._repository.insert(number_shipping, address_shipping, phone_shipping, id_driver);
    }
    
    // This method for delete Send by id
    public bool delete(int id_shipping)
    {
        return this._repository.delete(id_shipping);
    }
}