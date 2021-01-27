using OyunSatıs.Abstract;
using OyunSatıs.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Type +" kampanyası eklendi");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Type + " kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Type + " kampanyası güncellendi");
        }
    }
}
