using MongoProject.Entities;

namespace MongoProject.Services
{
    public interface IDepartmentService
    {
        Task<Department> AddDepartmentAsync(Department department);
        Task<Department> GetDepartmentByIdAsync(string id);
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
    }
}
