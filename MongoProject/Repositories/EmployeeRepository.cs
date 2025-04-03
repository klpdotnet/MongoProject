using Microsoft.Extensions.Options;
using MongoProject.Entities;
using MongoProject.Settings;

namespace MongoProject.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IOptions<MongoDBSettings> settings) : base(settings)
        {
        }
    }
}
