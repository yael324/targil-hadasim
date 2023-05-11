using DAL.Models;
using DTO.Models;

namespace DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<EmployeeDL, EmployeeDTO>();
            CreateMap<EmployeeDTO, EmployeeDL>();
            CreateMap<SickDL, SickDTO>();
            CreateMap<SickDTO, SickDL>();
            CreateMap<VaccinationDL, VaccinationDTO>();
            CreateMap<VaccinationDTO, VaccinationDL>();
        }
    }
}
