using System;
using System.Data.Entity;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(EfDbContext context) : base(context)
        {

        }

        public CustomAccount GetAccount(string id)
        {
            if(id == null)
                throw new ArgumentException(nameof(id));
            var account = Context.Users.FirstOrDefault(n => n.Id == id);

            //simple mapping between Account and CustomAccount to be free of Identity Entity Framework
            var result = new CustomAccount
            {
                FirstName = account.FirstName,
                LastName = account.LastName,
                Developer = account.Developer,
                AccountAdress = account.AccountAdress
            };
            return result;
        }
    }
}