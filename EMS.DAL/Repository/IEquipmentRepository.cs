using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public interface IEquipmentRepository
    {
        void AddEquipment(EquipmentModel equip);
        void UpdateEquipment(EquipmentModel equip);
        EquipmentModel GetEquipmentById(int id);
        IEnumerable<EquipmentModel> GetAll();
        void RemoveEquipment(int id);
        IEnumerable<EquipmentModel> GetEquipmentByName(string name);
       
        IEnumerable<EquipmentModel> GetAllEquipmentByStatus(string status);

    }
}
