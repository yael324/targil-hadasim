using DAL.Models;

namespace DAL.Classes
{
    public interface ISickDAL
    {
        Task AddSick(SickDL sick);
        Task<List<SickDL>> GetAllSicks();
        bool IsValid(SickDL sick);
    }
}