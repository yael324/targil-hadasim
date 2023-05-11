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
    public class VaccinationBL : IVaccinationBL
    {
        private readonly IVaccinationDAL _vaccinationDl;
        IMapper mapper;
        public VaccinationBL(IVaccinationDAL vaccinationDAL)
        {
            _vaccinationDl = vaccinationDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public async Task<List<VaccinationDTO>> GetAllVaccinations()
        {
            List<VaccinationDL> vaccination = await _vaccinationDl.GetAllVaccinations();
            return mapper.Map<List<VaccinationDL>, List<VaccinationDTO>>(vaccination);
        }


        public async Task AddVaccination(VaccinationDTO vaccination)
        {
            await _vaccinationDl.AddVaccination(mapper.Map<VaccinationDTO, VaccinationDL>(vaccination));
        }
    }
}
