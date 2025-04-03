using MongoProject.Entities;
using MongoProject.Repositories;

namespace MongoProject.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<Department> AddDepartmentAsync(Department department)
        {
            await _departmentRepository.CreateAsync(department);
            return department;
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }

        public async Task<Department> GetDepartmentByIdAsync(string id)
        {
            return await _departmentRepository.GetByIdAsync(id);
        }
    }
}
