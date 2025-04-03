using Microsoft.Extensions.Options;
using MongoProject.Entities;
using MongoProject.Settings;

namespace MongoProject.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(IOptions<MongoDBSettings> settings) : base(settings)
        {
        }
    }
}
