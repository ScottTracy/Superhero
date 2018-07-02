﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero.Models
{
    public class Superhero
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; } 
        public string primaryAbility { get; set; }
        public string secondaryAbility { get; set; }
        public string catchphrase { get; set; }
    }
}