using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tridion.Snitch.Application.library
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<UserAction> UserActions { get; set; }
    }
}
