using VisitorForMongoDb.Core.Entities;
using VisitorForMongoDb.Interfaces.Repositories;

namespace VisitorForMongoDb.Infrastructure.Repositories
{
    public class FormRepository : IFormRepository
    {
        public Task<FormEntity> GetForm()
        {
            throw new NotImplementedException();
        }
    }
}
