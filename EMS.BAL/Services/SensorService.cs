using EMS.DAL.Repository;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BAL.Services
{
    public class SensorService
    {
        ISensorRepository _SensorRepository;
        public SensorService(ISensorRepository sensorRepository)
        {
            _SensorRepository = sensorRepository;
        }
        public string AddSensor(SensorModel sensor)
        {
            return  _SensorRepository.AddSensor(sensor);
        }
        public void RemoveSensor(int id) 
        {
            _SensorRepository.DeleteSensor(id);
        }
        public SensorModel GetSensor(int id) 
        {
           return  _SensorRepository.GetSensorById(id);
        }
        public IEnumerable<SensorModel> GetAllSensors() 
        {
            return _SensorRepository.GetAllSensors();
        }
        public void UpdateSensor(SensorModel sensor)
        {
            _SensorRepository.UpdateSensor(sensor);
        }
    }
}
