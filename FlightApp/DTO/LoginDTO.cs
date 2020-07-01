﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.DTO
{
    public class LoginDTO
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public LoginDTO(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}