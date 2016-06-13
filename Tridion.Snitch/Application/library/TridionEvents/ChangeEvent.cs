using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using Tridion.ContentManager.ContentManagement;
using Tridion.ContentManager.Extensibility;
using Tridion.ContentManager.Extensibility.Events;
using Tridion.Snitch.Application.communication;
using Tridion.Snitch.Application.Data_access.Repository;
using Tridion.Logging;


namespace Tridion.Snitch.Application.library.TridionEvents
{
    [TcmExtension("TridionSnitch")]
    public class ChangeEvent: TcmExtension
    {
        public ChangeEvent()
        {
	        Subscribe();
        }

        public void Subscribe()
        {
            // OnComponentSavePre
            EventSystem.Subscribe<VersionedItem, SaveEventArgs>(OnItemSavePre, EventPhases.Initiated);
        }
        private static void OnItemSavePre(VersionedItem item, SaveEventArgs args, EventPhases phase)
        {
            var title = item.Title;
            var writer = new FileWriter();
            //var repo = new UserActionRepository(new SnitchDb());
            //var UserRepo = new UserRepository(new SnitchDb());
            var action = new UserAction()
            {
                
                Status = item.Revision.ToString(),
                ActionDetails = item.WebDavUrl,
                ActionName = item.Title,
                ActionTime = item.RevisionDate
            }; 

            var item4 = args;
            var check = "";
            var user = new User()
            {
                
                Name = item.Session.User.Title,
                UserName = item.Session.User.Id,
                UserActions = new List<UserAction>()
                {
                    new UserAction()
                    {
                        
                        ActionDetails = item.WebDavUrl,
                        ActionName = item.Title,
                        ActionTime = DateTime.Now
                    }
                }
            };
            //repo.Add(action);
            //UserRepo.Add(user);
            Logger.Write("[OnItemSavePre];","could not work",LoggingCategory.General);
   writer.WriteAction(user);
           
            args.ContextVariables.Add(title, DateTime.Now);
        }
    }


}
