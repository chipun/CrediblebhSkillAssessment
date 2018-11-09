using System;
using System.Collections.Generic;
using System.Linq;
using Credible.WebApp.Models;
using Credible.WebApp.DAL;

namespace Credible.WebApp.Repositories
{
    public class UserRepository : IRepository<User>
    {
        UserContext _db;

        public UserRepository(UserContext db)
        {
            _db = db;
        }

        public void Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public ICollection<User> SelectAll()
        {
            return _db.Users;
        }

        public User SelectById(int id)
        {
            return _db.Users.Where(x => x.user_id == id).First();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
