using OyunSatıs.Abstract;
using OyunSatıs.Concrete;
using OyunSatıs.Entities;
using System;

namespace OyunSatıs
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { DateofBirth = new DateTime(2000, 5, 7), FirstName = "Faruk", LastName = "Demirkan", NationalityId = "4567912311" };
            BaseCustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            Campaign campaign = new Campaign { Id = 1, Type = "Öğrenci" };
            CampaignManager campaignManager = new CampaignManager();
            Game game = new Game { Id=1, Name= "GTA6"};
            customerManager.CampaignSale(customer, game, campaign);
            campaignManager.Add(campaign);
            customerManager.Buy(customer, game);
            customerManager.Save(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);

        }
    }
}
