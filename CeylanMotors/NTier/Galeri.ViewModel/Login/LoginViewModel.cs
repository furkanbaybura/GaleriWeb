﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Login
{
    public class LoginViewModel
    {
        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Password)]

        public string Password { get; set; }

    }
}
