using EMS.BAL.Services;
using EMSEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    

    public class SensorController : ControllerBase
    {
        private SensorService _SensorService;
        public SensorController(SensorService sensorService)
        {
            _SensorService = sensorService;
        }
        [HttpPost("AddSensor")]
        public IActionResult AddSensor(SensorModel sensor)
        {
 
             string msg= _SensorService.AddSensor(sensor);
            List<object> list = new List<object>();

            list.Add(msg);
            return Ok(list);

        }
        [HttpGet("GetAllSensors")]
        public IEnumerable<SensorModel> GetSensors() 
        {
            return _SensorService.GetAllSensors();
        }
        [HttpGet("GetSensorById")]
        public SensorModel GetSensorById(int id) 
        {
            return _SensorService.GetSensor(id);
        }
        [HttpPut("UpdateSensor")]
        public IActionResult updateSensor(SensorModel sensor) 
        {
            _SensorService.UpdateSensor(sensor);
            List<object> list = new List<object>();

            list.Add("Updated the sensor");
            return Ok(list);

        }
        [HttpDelete("DeleteSensor")]
        public IActionResult DeleteSensor(int id) 
        {
      
            _SensorService.RemoveSensor(id);
            List<object> list = new List<object>();

            list.Add("Deleted the sensor");
            return Ok(list);
        }
    }
}
