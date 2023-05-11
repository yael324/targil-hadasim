using DTO.Models;

namespace BL.Classes
{
    public interface ISickBL
    {
        Task AddSick(SickDTO sick);
        Task<List<SickDTO>> GetAllSicks();
    }
}