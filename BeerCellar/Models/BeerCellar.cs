using System;
using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class BeerCellar
    {
        public BeerCellar()
        {
            Beers = new List<Beer>();
        }

        public IEnumerable<Beer> Beers { get; set; }
    }
}
