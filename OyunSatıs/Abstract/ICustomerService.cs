using OyunSatıs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        void Buy(Customer customer, Game game);
        void CampaignSale(Customer customer, Game game, Campaign campaign);
    }
}
