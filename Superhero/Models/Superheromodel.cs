﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero.Models
{
    public class Superheromodel
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; } 
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}