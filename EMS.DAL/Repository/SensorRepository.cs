using EMS.DAL.Data;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public class SensorRepository : ISensorRepository
    {  
        EMSDbContext _context;
        public SensorRepository(EMSDbContext context)
        {
            _context = context;
        }

        public string AddSensor(SensorModel sensor)
        {
            EquipmentModel equipment = _context.Equipment.Find(sensor.EqId);
            if (equipment == null) 
            {
               return "The equipment is not there in the table ";
            }
            else
            {
                _context.Sensor.Add(sensor);
                _context.SaveChanges();
                return "Inserted";
            }
                

        }

        public void DeleteSensor(int id)
        {

                var element = _context.Sensor.Find(id);
                _context.Sensor.Remove(element);
                _context.SaveChanges();
      

        }

        public IEnumerable<SensorModel> GetAllSensors()
        {
 
                return _context.Sensor.ToList();
      
        }

        public SensorModel GetSensorById(int id)
        {

                return _context.Sensor.Find(id);


        }

        public void UpdateSensor(SensorModel sensor)
        {

                _context.Sensor.Update(sensor);
                _context.SaveChanges();
 

        }
    }
}
