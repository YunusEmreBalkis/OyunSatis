using OyunSatıs.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Entities
{
    public class Campaign: IEntity
    {
        public string Type { get; set; }
        public int Id { get; set; }
    }
}
