using System;
using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class Cellar
    {
        public Cellar()
        {
            Beers = new List<Beer>();
        }

        public IEnumerable<Beer> Beers { get; set; }
    }
}
