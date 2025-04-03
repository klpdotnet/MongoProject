using MongoProject.Entities;

namespace MongoProject.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(string id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<Employee> UpdateEmployeeAsync(string id, Employee employee);
        Task DeleteEmployeeAsync(string id);
    }
}
