using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class Brewer
    {
        public Brewer()
        {
        }

        public int? Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Beer> Beers { get; set; }
    }
}
