using EMS.BAL.Services;
using EMSEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicianController : ControllerBase
    {
         private TechnicianService _TechService;
        public TechnicianController(TechnicianService tech)
        {
            _TechService = tech;
        }
        [HttpPost("AddTechnician")]
        public IActionResult AddTechnician(TechnicianModel tech)
        {
            _TechService.AddTechnician(tech);
            List<object> list = new List<object>();

            list.Add("Added Technician");
            return Ok(list);
        }

        [HttpGet("GetTechnicianById")]
        public TechnicianModel GetTechnicianById(int id) 
        {
            return _TechService.GetTechnician(id);
        }
        [HttpDelete("DeleteTechnicianById")]
        public IActionResult DeleteTechnician(int id)
        {
            _TechService.RemoveTechnician(id);
            List<object> list = new List<object>();
            list.Add("Deleted Technician");
            return Ok(list);
        }
        [HttpPut("UpdateTechnician")]
        public IActionResult UpdateTechnicianDetails(TechnicianModel technician) 
        {
            _TechService.UpdateTechnician(technician);
            List<object> list = new List<object>();
            list.Add("Updated the details");
            return Ok(list);
        }
        [HttpGet("GetAll")]
        public IEnumerable<TechnicianModel> GetAllTechnicians()
        {
           return  _TechService.GetAll();
        }
    }
}
