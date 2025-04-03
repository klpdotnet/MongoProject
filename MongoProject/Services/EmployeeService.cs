using MongoProject.Entities;
using MongoProject.Repositories;

namespace MongoProject.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            await _employeeRepository.CreateAsync(employee);
            return employee;
        }

        public async Task DeleteEmployeeAsync(string id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee> GetEmployeeByIdAsync(string id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task<Employee> UpdateEmployeeAsync(string id, Employee employee)
        {
            return await _employeeRepository.UpdateAsync(id, employee);
        }
    }
}
