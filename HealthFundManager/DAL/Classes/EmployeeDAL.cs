using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly HealthFundManagerContext _context;
        public EmployeeDAL(HealthFundManagerContext context)
        {
            this._context = context;
        }
        public async Task<List<EmployeeDL>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task AddEmployee(EmployeeDL employee)
        {
            if (!IsValid(employee))
                throw new Exception("you must fill all the required feild");
            await _context.Employees.AddAsync(employee);
            _context.SaveChanges();
        }

        public bool IsValid(EmployeeDL employee)
        {
            if (employee.Id != null && employee.FirstName != null && employee.LastName != null && employee.Address != null &&
                employee.DateOfBirth != null && employee.MobilePhone != null)
                return true;
            return false;
        }
    }
}
