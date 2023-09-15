using EMS.BAL.Services;
using EMSEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
       private EquipmentService _EqService;

        public EquipmentController(EquipmentService EqService)
        {
              _EqService= EqService;
        }
        [HttpPost("AddEquipment")]
        public IActionResult AddEquipment(EquipmentModel Equip)
        {
  
                List<object> list = new List<object>();
                _EqService.AddEquipment(Equip);
                list.Add("inserted");
       
                return Ok(list);


        }
        [HttpGet("GetAll")]
        public IEnumerable<EquipmentModel> GetAllEquipment() 
        {

               
                return _EqService.GetAll();

        }
        [HttpGet("status")]
        public IEnumerable<EquipmentModel> GetElementByStatus(string status) 
        {
                return _EqService.GetEquipmentsByStatus(status);
           
        }
        [HttpGet("id")]
        public EquipmentModel GetEquipmentById(int id)
        {

                return _EqService.GetEquipment(id);

 
        }

        [HttpDelete("DeleteEquipment")]
        public IActionResult DeleteEquipment(int id) 
        {
            
                _EqService.Remove(id);
                List<object> list = new List<object>();
               
                list.Add("deleted");
                return Ok(list);
   
        }

        [HttpPut("UpdateEquipment")]
        public IActionResult UpdateEquipment(EquipmentModel equip)
        {
            _EqService.Update(equip);
            List<object> list = new List<object>();

            list.Add("Updated the equipment");
            return Ok(list);
        }
        [HttpGet("Eqname")]
        public IEnumerable<EquipmentModel> GetEquipmentByName(string name) 
        { 
              return _EqService.GetEquipmentByName(name);
        }
    }

}
