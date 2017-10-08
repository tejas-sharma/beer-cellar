﻿using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<BeerCellar> BeerCellars { get; set; }
    }
}