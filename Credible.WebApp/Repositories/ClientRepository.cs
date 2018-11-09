using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Credible.WebApp.DAL;
using Credible.WebApp.Models;

namespace Credible.WebApp.Repositories
{
    public class ClientRepository : IRepository<Client>
    {
        private ClientContext _db;
        private DbSet<Client> _dbSet;

        public ClientRepository(ClientContext db)
        {
            _db = db;
            _dbSet = db.Set<Client>();

        }

        public ICollection<Client> SelectAll()
        {

            return _db.Clients;
        }


        public void Delete(Client obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(Client obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }



        public Client SelectById(int id)
        {

            return _db.Clients.Where(x => x.portal_id == id).First();

            //return _db.GetClientByID(id);
        }

        public void Update(Client obj)
        {
            throw new NotImplementedException();
        }
    }
}
