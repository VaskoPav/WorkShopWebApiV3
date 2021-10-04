using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Models.Users
{
    public class RegisterUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
    }
}
