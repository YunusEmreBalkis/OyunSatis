using OyunSatıs.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatıs.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}
