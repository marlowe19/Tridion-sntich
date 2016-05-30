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
           var File = string.Format(@"C:\Temp\Tridion-snitch\{0}.txt", cleanFileName(userName));

           return File;
       }

       private string cleanFileName(string fileName){

           var cleanName = fileName.Split('\\')[1];
           return cleanName;
       }


       public void WriteAction(User user)
       {
           
            File.AppendAllLines(CreateFileName(user.Name), user.UserActions.Select(x=> x.Line));

           var allLines = File.ReadLines(CreateFileName(user.Name)).FirstOrDefault(x=> x.Contains("top"));
          
       }
   }
}
