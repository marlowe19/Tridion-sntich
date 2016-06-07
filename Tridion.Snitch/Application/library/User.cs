using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridion.Snitch.Application.library
{
    public class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public IEnumerable<UserAction> UserActions { get; set; }
    }
}
