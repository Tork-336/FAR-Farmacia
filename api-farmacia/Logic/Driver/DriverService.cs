using System;
using Data.Driver;
using System.Data;

namespace Logic.Driver
{
	public class DriverService
	{
		private DriverRepository repository;

		public DataSet List()
		{
			return this.repository.list();
		}

        public bool update(int id_driver, int identification_driver, string numberLicense_driver,
            string name_driver, string surname_driver, int phone_driver, int age_driver, char gender_driver,
            string typeLicense)
		{
			return this.repository.update(id_driver, identification_driver, numberLicense_driver,
				name_driver, surname_driver, phone_driver, age_driver, gender_driver, typeLicense);
		}

        public bool insert(int identification_driver, string numberLicense_driver,
            string name_driver, string surname_driver, int phone_driver, int age_driver, char gender_driver,
            string typeLicense)
		{
			return this.repository.insert(identification_driver, numberLicense_driver, name_driver, surname_driver,
				phone_driver, age_driver, gender_driver, typeLicense);
		}

        public bool delete(int id_driver)
		{
			return this.repository.delete(id_driver);
		}
    }
}

