using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.Snitch.Application.library;

namespace Tridion.Snitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new FileWriter();
            var user = new User()
            {
              
                Name = "John",
                UserActions = new List<UserAction>()
                {
                    new UserAction()
                    {
                        ActionDetails = "/webdav/template/url/to/template",
                        ActionName = "ComponentTemplate",
                        ActionTime = DateTime.Now
                    }
                }
            };

            writer.WriteAction(user);

            Console.ReadLine();
        }
    }
}
