using DAL.Models;

namespace DAL.Classes
{
    public interface IEmployeeDAL
    {
        Task AddEmployee(EmployeeDL employee);
        Task<List<EmployeeDL>> GetAllEmployees();
        bool IsValid(EmployeeDL employee);
    }
}