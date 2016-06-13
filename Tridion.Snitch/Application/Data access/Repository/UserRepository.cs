using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tridion.Snitch.Application.communication;
using Tridion.Snitch.Application.library;

namespace Tridion.Snitch.Application.Data_access.Repository
{
    public class UserRepository : IRepository<User, string>
    {
        private SnitchDb _database;

        public UserRepository(SnitchDb database)
        {
            _database = database;
        }

        public ICollection<User> All()
        {
            return _database.Users.ToList();
        }

        public User Find(string userId)
        {
            return _database.Users.Find(userId);
        }

        public void Add(User entity)
        {
            _database.Users.Add(entity);
            _database.SaveChanges();
        }

        public void Delete(string userId)
        {
            var user = Find(userId);
            _database.Users.Remove(user);
        }
    }
}
