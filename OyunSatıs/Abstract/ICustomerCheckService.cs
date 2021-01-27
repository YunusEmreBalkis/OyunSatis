using OyunSatıs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer); 
    }
}
