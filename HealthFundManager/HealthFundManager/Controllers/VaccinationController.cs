using BL.Classes;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthFundManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        
        private readonly IVaccinationBL _vaccinationBL;
        public VaccinationController(IVaccinationBL vaccinationBL)
        {
            _vaccinationBL = vaccinationBL;
        }
        
        [HttpGet]
        [Route("GetAllVaccination")]
        public async Task<IActionResult> GetAllVaccination()
        {
            try
            {
                List<VaccinationDTO> vaccinations = await _vaccinationBL.GetAllVaccinations();
                return Ok(vaccinations);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPost]
        [Route("AddVaccination")]
        public async Task<IActionResult> AddVaccination([FromBody] VaccinationDTO vaccination)
        {
            try
            {
                await _vaccinationBL.AddVaccination(vaccination);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       
    }
}
