using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public interface ISensorRepository
    {
        string AddSensor(SensorModel sensor);
        void UpdateSensor(SensorModel sensor);
        void DeleteSensor(int id);
        SensorModel GetSensorById(int id);
        IEnumerable<SensorModel> GetAllSensors();

    }
}
