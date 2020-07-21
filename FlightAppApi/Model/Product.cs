﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace FlightAppApi.Model
{
    public class Product
    {
        [Required]
        public int Id { get; private set; }
        [Required]
        public string Name { get; set; }

        //public Bitmap Image { get; set; }       

    }
}
