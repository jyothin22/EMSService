using EMS.BAL.Services;
using EMSEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        MaintenanceService _MaintainService;
        public MaintenanceController(MaintenanceService maintain) 
        {
            _MaintainService= maintain;
        }
        [HttpPost("AddMaintenance")]
        public IActionResult AddMaintenance(MaintenanceModel model)
        {
           
              string msg=_MaintainService.AddMaintenance(model);
            List<object> list = new List<object>();

            list.Add(msg);
            return Ok(list);
           
        }
        [HttpGet("GetAll")]
        public IEnumerable<MaintenanceModel> GetMaintenance() 
        {
            return _MaintainService.GetAll();
        }
        [HttpGet("GetByStatus")]
        public IEnumerable<MaintenanceModel> GetByStatus(string status)
        {
            return _MaintainService.GetMaintenanceByStatus(status);

        }
        [HttpGet("GetByType")]
        public IEnumerable<MaintenanceModel> GetByType(string type)
        {
            return _MaintainService.GetMaintenanceByType(type);

        }
        [HttpGet("GetMaintenanceById")]
        public MaintenanceModel GetMaintenanceById(int id) 
        {
             return _MaintainService.GetMaintenance(id);
        }
        [HttpDelete("DeleteMaintenance")]
        public IActionResult DeleteMaintenance(int id) 
        {
            _MaintainService.DeleteMaintenance(id);
            List<object> list = new List<object>();

            list.Add("Deleted the Maintenance of ID:" + id);
            return Ok(list);
           

        }
        [HttpPut("UpdateMaintenance")]
        public IActionResult UpdateMaintenance(MaintenanceModel model) 
        {
            _MaintainService.UpdateMaintenanceModel(model);
            List<object> list = new List<object>();

            list.Add("Updated the Maintenance");
            return Ok(list);
        }

    }
}
