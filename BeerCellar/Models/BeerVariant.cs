using System;

namespace BeerCellar.Models
{
    public class BeerVariant
    {
        public DateTime? Year { get; set; }
        public Beer Beer { get; set; }
    }
}