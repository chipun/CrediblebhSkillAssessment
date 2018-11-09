using System;
using System.Collections.Generic;
using System.Linq;
using Credible.WebApp.DAL;
using Credible.WebApp.Models;

namespace Credible.WebApp.Repositories
{
    public class RegistrationRepository: IRepository<RegistratedUser>
    {
        private RegistrationContext _db;

        public RegistrationRepository(RegistrationContext db)
        {
            _db = db;
        }

        public void Delete(RegistratedUser obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(RegistratedUser obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public ICollection<RegistratedUser> SelectAll()
        {
            return _db.RegistratedUsers;
        }

        public RegistratedUser SelectById(int id)
        {
            return _db.RegistratedUsers.Where(x => x.registration.course_portal_id == id).First();
        }

        public ICollection<RegistratedUser> SelectSomeByPortalId(int id)
        {
            return _db.RegistratedUsers.Where(x => x.registration.course_portal_id == id).ToList();
        }

        public void Update(RegistratedUser obj)
        {
            throw new NotImplementedException();
        }
    }
}
