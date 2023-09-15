using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using EMS.DAL.Data; 
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EMS.DAL.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {
        EMSDbContext _context;
        public EquipmentRepository(EMSDbContext context )
        {
            _context = context;
        }
        public void AddEquipment(EquipmentModel equip)
        {
            
                _context.Equipment.Add(equip);
                _context.SaveChanges();
         
        }

        public IEnumerable<EquipmentModel> GetAll()
        {
                return _context.Equipment.ToList();
        }

        public IEnumerable<EquipmentModel> GetAllEquipmentByStatus(string status)
        {

                IEnumerable<EquipmentModel> equip = _context.Equipment.ToList();
                return equip.Where(equip => equip.EqStatus == status).ToList();
        }

        public EquipmentModel GetEquipmentById(int id)
        {
                EquipmentModel equipment = _context.Equipment.Find(id);
                return equipment;

        }

        public IEnumerable<EquipmentModel> GetEquipmentByName(string name)
        {
                IEnumerable<EquipmentModel> equip = _context.Equipment.ToList();
                return equip.Where(equip => equip.EqType == name).ToList();
            
        }
        public void RemoveEquipment(int id)
        {
   
                var equipment = _context.Equipment.Find(id);
                _context.Equipment.Remove(equipment);
                 Console.WriteLine("done");
                _context.SaveChanges();

        }

        public void UpdateEquipment(EquipmentModel equip)
        { 
                _context.Entry(equip).State = EntityState.Modified;
                _context.SaveChanges();
           
        }

 
    }
}
