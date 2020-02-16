using System.Collections.Generic;
using System.Threading.Tasks;
using onlinediary.core.Models.Db;
using onlinediary.domain.Repository;

namespace onlinediary.infrastructure.Repository
{
    public class ContactRepository : IContactRepository
    {
        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public object GetById(in long id)
        {
            throw new System.NotImplementedException();
        }
    }
}