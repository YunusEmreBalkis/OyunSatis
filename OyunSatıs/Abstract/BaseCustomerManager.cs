using OyunSatıs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Buy(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName +" "+ customer.LastName+" müşterisi "+ game.Name +" oyununu satın aldı");
        }

        public void CampaignSale(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " müşterisi " + game.Name + " oyununu "+campaign.Type+ " kampanyası ile satın aldı");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi " + customer.FirstName);
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Kayıt Oldu " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Güncellendi " + customer.FirstName);
        }
    }
}
