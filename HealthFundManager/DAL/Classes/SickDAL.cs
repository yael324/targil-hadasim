using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Classes
{
    public class SickDAL : ISickDAL
    {
        private readonly HealthFundManagerContext _context;

        public SickDAL(HealthFundManagerContext context)
        {
            this._context = context;
        }
        public async Task<List<SickDL>> GetAllSicks()
        {
            return await _context.Sicks.ToListAsync();
        }

        public async Task AddSick(SickDL sick)
        {
            await _context.Sicks.AddAsync(sick);
            _context.SaveChanges();
        }
        public bool IsValid(SickDL sick)
        {
            if (sick.Id != null && sick.datePositiveResult != null && sick.dateOfRecovery != null)
                return true;
            return false;
        }
    }
}
