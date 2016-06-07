using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Tridion.Snitch.Application.library;

namespace Tridion.Snitch.WebApp.Models
{
    public class Peeps
    {
        public List<User> UserList { get; set; }
    }
}