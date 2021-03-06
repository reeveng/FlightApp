﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightAppApi.Model
{
    public abstract class Person
    {
        [Required]
        public int PersonId { get; private set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public string Name
        {
            get => FirstName + " " + LastName;
        }
    }
}
