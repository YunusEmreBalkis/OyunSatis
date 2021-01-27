using OyunSatıs.Abstract;
using OyunSatıs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil");
            }
           
        }
    }
}
