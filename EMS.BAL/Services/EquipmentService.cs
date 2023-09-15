using EMS.DAL.Repository;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BAL.Services
{
    public class EquipmentService
    {
        IEquipmentRepository _EquipRepository;
        public EquipmentService(IEquipmentRepository equipRepository)
        {
            _EquipRepository = equipRepository; 
        }
        public void AddEquipment(EquipmentModel equip)
        {
             _EquipRepository.AddEquipment(equip);
        }
        public EquipmentModel GetEquipment(int id)
        {
            return _EquipRepository.GetEquipmentById(id);
        }
        public IEnumerable<EquipmentModel> GetEquipmentsByStatus(string status)
        {
            return _EquipRepository.GetAllEquipmentByStatus(status);
        }
        public IEnumerable<EquipmentModel> GetEquipmentByName(string name) 
        {
            return _EquipRepository.GetEquipmentByName(name);
        }
        public void Update(EquipmentModel equip) 
        {
            _EquipRepository.UpdateEquipment(equip);
        }
        public void Remove(int id)
        {
            _EquipRepository.RemoveEquipment(id);
        }

        public IEnumerable<EquipmentModel> GetAll()
        {
            return _EquipRepository.GetAll();
        }

    }
}
