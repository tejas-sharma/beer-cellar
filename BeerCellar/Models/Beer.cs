﻿using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class Beer
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Brewer Brewer { get; set; }
        public IEnumerable<BeerVariant> Variants { get; set; }
    }
}