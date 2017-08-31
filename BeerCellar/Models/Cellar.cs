using System;
using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class Cellar
    {
        public Cellar()
        {
        }

        public IEnumerable<Beer> Beers { get; set; }
    }
}
