using AutoMapper;
using DAL.Classes;
using DAL.Models;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Classes
{
    public class EmployeeBL : IEmployeeBL
    {
        private readonly IEmployeeDAL _employeeDl;
        IMapper mapper;
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            _employeeDl = employeeDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public async Task<List<EmployeeDTO>> GetAllEmployees()
        {
            List<EmployeeDL> employee = await _employeeDl.GetAllEmployees();
            return mapper.Map<List<EmployeeDL>, List<EmployeeDTO>>(employee);
        }

        public async Task AddEmployee(EmployeeDTO employee)
        {
            await _employeeDl.AddEmployee(mapper.Map<EmployeeDTO, EmployeeDL>(employee));
        }
    }
}
