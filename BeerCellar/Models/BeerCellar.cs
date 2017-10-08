using System;
using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class BeerCellar
    {
        public BeerCellar()
        {
        }

        public IEnumerable<Beer> Beers { get; set; }
        public string Name { get; set; }
        public User Owner { get; set; }
        public string Id { get; set; }
    }
}
