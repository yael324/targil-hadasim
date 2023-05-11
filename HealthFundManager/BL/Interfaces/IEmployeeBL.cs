using DTO.Models;

namespace BL.Classes
{
    public interface IEmployeeBL
    {
        Task AddEmployee(EmployeeDTO employee);
        Task<List<EmployeeDTO>> GetAllEmployees();
    }
}