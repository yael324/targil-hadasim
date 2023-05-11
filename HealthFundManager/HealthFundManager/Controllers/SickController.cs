using BL.Classes;
using DTO.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthFundManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SickController : ControllerBase
    {
        
        private readonly ISickBL _sickBL;
        public SickController(ISickBL sickBL)
        {
            _sickBL = sickBL;
        }
        
        [HttpGet]
        [Route("GetAllSicks")]
        public async Task<IActionResult> GetAllSicks()
        {
            try
            {
                List<SickDTO> sicks = await _sickBL.GetAllSicks();
                return Ok(sicks);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpPost]
        [Route("AddSick")]
        public async Task<IActionResult> AddSick([FromBody] SickDTO sick)
        {
            try
            {
                await _sickBL.AddSick(sick);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
       
    }
}
