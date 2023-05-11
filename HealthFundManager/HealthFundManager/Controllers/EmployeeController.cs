using BL.Classes;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthFundManager.Controllers
{
    public class EmployeeController : Controller
    {
       
        private readonly IEmployeeBL _employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
            _employeeBL = employeeBL;
        }
        
        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                List<EmployeeDTO> employees = await _employeeBL.GetAllEmployees();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

       
        [HttpPost]
        [Route("AddEmployee")]
        public async Task<IActionResult> AddEmployee([FromBody] EmployeeDTO employee)
        {
            try
            {
                await _employeeBL.AddEmployee(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
