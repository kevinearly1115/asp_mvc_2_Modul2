﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp_mvc_2.Models.ViewModel
{
    public class UserLoginView
    {
        [Key]
        public int SYSUserID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

    public class UserSignUpView
    {
        [Key]
        public int SYSUserID { get; set; }
        public int LOOKUPRoleID { get; set; }
        public string RoleName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Login ID")]
        public string LoginName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}