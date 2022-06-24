﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_market.Core.Application.ViewModels.Users
{
    public class LoginUserViewModel
    {
        [Required(ErrorMessage = "You need to specify your UserName")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You need to specify your password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
