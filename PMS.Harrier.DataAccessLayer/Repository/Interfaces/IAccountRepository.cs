using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;

namespace PMS.Harrier.DataAccessLayer.Repository.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetAccount(string id);
    }
}