using DAL.Models;

namespace DAL.Classes
{
    public interface IVaccinationDAL
    {
        Task AddVaccination(VaccinationDL vaccination);
        Task<List<VaccinationDL>> GetAllVaccinations();
        bool IsValid(VaccinationDL vaccination);
    }
}