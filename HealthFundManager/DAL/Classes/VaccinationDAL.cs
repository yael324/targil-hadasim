using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class VaccinationDAL : IVaccinationDAL
    {
        private readonly HealthFundManagerContext _context;
        public VaccinationDAL(HealthFundManagerContext context)
        {
            this._context = context;
        }
        public async Task<List<VaccinationDL>> GetAllVaccinations()
        {
            return await _context.Vaccinations.ToListAsync();
        }

        public async Task AddVaccination(VaccinationDL vaccination)
        {
            if (!IsValid(vaccination))
                throw new Exception("you must fill all the required feild");
            await _context.Vaccinations.AddAsync(vaccination);
            _context.SaveChanges();
        }
        public bool IsValid(VaccinationDL vaccination)
        {
            if (vaccination.Id != null && vaccination.DateOfVaccination != null && vaccination.VaccineProducer != null)
                return true;
            return false;
        }
    }
}
