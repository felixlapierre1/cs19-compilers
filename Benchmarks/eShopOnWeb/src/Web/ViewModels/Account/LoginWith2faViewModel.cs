﻿using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.Web.ViewModels.Account
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; } // @issue@I02

        [Display(Name = "Remember this machine")]
        public bool RememberMachine { get; set; } // @issue@I02

        public bool RememberMe { get; set; } // @issue@I02
    }
}
