using DTO.Models;

namespace BL.Classes
{
    public interface IVaccinationBL
    {
        Task AddVaccination(VaccinationDTO vaccination);
        Task<List<VaccinationDTO>> GetAllVaccinations();
    }
}