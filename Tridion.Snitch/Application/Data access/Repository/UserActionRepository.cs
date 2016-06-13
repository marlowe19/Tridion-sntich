using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tridion.Snitch.Application.communication;
using Tridion.Snitch.Application.library;

namespace Tridion.Snitch.Application.Data_access.Repository
{
    public class UserActionRepository: IRepository<UserAction,string>
    {
        private SnitchDb _database;

        public UserActionRepository(SnitchDb database)
        {
            _database = database;
        }
        public ICollection<UserAction> All()
        {
            return _database.UserAction.ToList();
        }

        public UserAction Find(string userId)
        {
            return _database.UserAction.Find(userId);
        }

        public void Add(UserAction entity)
        {
            _database.UserAction.Add(entity);
            _database.SaveChanges();
        }

        public void Delete(string userId)
        {
            var user = Find(userId);
            _database.UserAction.Remove(user);
        }
    }
}
