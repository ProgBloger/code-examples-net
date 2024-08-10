using VisitorForMongoDb.Core.Entities;

namespace VisitorForMongoDb.Interfaces.Repositories
{
    public interface IFormRepository
    {
        Task<FormEntity> GetForm();
    }
}
