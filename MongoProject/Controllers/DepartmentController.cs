using Microsoft.AspNetCore.Mvc;
using MongoProject.Entities;
using MongoProject.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MongoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService departmentService) : ControllerBase
    {
        private readonly IDepartmentService _departmentService = departmentService;

        [HttpPost]
        public async Task<IActionResult> AddDeprtment([FromBody] Department department)
        {
            if (department == null) return BadRequest("Invalid department data");
            var createdDEpartment = await _departmentService.AddDepartmentAsync(department);
            return CreatedAtAction(nameof(GetDepartmentById), new { id = createdDEpartment.Id }, createdDEpartment);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(string id)
        {
            var department = await _departmentService.GetDepartmentByIdAsync(id);
            if (department == null) return NotFound();
            return Ok(department);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartment()
        {
            var departments = await _departmentService.GetAllDepartmentsAsync();
            if (departments == null) return NotFound();
            return Ok(departments);
        }
    }
}
