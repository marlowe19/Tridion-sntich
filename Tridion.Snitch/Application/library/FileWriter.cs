using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.Snitch.Application.Contracts;

namespace Tridion.Snitch.Application.library
{
   public class FileWriter : IFileWriter
   {
       public string GetName()
       {
           throw new NotImplementedException();
       }

       public string GetAction()
       {
           throw new NotImplementedException();
       }

       private string CreateFileName(string userName)
       {
           var File = string.Format(@"C:\Users\Marlowe\Documents\{0}.txt", userName);

           return File;
       }

       public void WriteAction(User user)
       {
           
        
            File.AppendAllLines(CreateFileName(user.Name), user.UserActions.Select(x=> x.Line));

           var allLines = File.ReadLines(CreateFileName(user.Name)).FirstOrDefault(x=> x.Contains("top"));
            Console.WriteLine("Done");
       }
   }
}
