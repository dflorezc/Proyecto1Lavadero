using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebFullCar.Models
{
    public class LoginModel 
    {
        public string Username { get;set;}
        public string Password { get; set; }
    }
}