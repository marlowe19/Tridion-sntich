using System;

namespace Tridion.Snitch.Application.library
{
    public class UserAction
    {
        public string ActionName { get; set; }
        public string ActionDetails { get; set; }
        public DateTime ActionTime { get; set; }
        public DateTime EntryTime
        {
            get
            {
                return DateTime.Now;
            }
        }

        public string Line
        {
            get
            {
                return string.Format("{0}  |  {1}  |  {2}  |  {3}",ActionName, ActionDetails,
                    ActionTime, EntryTime);
            }
        }


    }
}