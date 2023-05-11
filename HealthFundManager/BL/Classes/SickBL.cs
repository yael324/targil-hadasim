using AutoMapper;
using DAL.Classes;
using DAL.Models;
using DTO;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Classes
{
    public class SickBL : ISickBL
    {
        private readonly ISickDAL _sickDl;
        IMapper mapper;
        public SickBL(ISickDAL sickDAL)
        {
            _sickDl = sickDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public async Task<List<SickDTO>> GetAllSicks()
        {
            List<SickDL> sick = await _sickDl.GetAllSicks();
            return mapper.Map<List<SickDL>, List<SickDTO>>(sick);
        }


        public async Task AddSick(SickDTO sick)
        {
            await _sickDl.AddSick(mapper.Map<SickDTO, SickDL>(sick));
        }
    }
}
