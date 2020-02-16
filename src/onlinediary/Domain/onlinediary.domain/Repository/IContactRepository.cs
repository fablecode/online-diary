using System.Collections.Generic;
using System.Threading.Tasks;
using onlinediary.core.Models.Db;

namespace onlinediary.domain.Repository
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAll();
        object GetById(in long id);
    }
}