using System;
using System.Collections.Generic;
using Tridion.ContentManager.ContentManagement;
using Tridion.ContentManager.Extensibility;
using Tridion.ContentManager.Extensibility.Events;


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
            
            var item4 = args;
            var user = new User()
            {
                LastName = "Doe",
                Name = item.Session.User.Title,
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
            writer.WriteAction(user);
            args.ContextVariables.Add(title, DateTime.Now);
        }
    }


}
