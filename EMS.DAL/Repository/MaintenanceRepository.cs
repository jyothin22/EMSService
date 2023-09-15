using EMS.DAL.Data;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public class MaintenanceRepository : IMaintenanceRepository
    {
        EMSDbContext _context;
        public MaintenanceRepository(EMSDbContext emd)
        {
             _context= emd;
        }
        public string  AddMaintenance(MaintenanceModel maintain)
        {
             EquipmentModel equip = _context.Equipment.Find(maintain.EqId);
             TechnicianModel tech = _context.Technician.Find(maintain.TechId);
              if(equip==null)
            {
                 return "The equipment is not there in theequipment  table ";
            }
              else if(tech==null) 
            {
                return "The Technician is not there in the table ";
            }
            else
            {
                _context.Maintenance.Add(maintain);
                _context.SaveChanges();
                return "Inserted the record";
            }

        }

        public IEnumerable<MaintenanceModel> GetAll()
        {

                return _context.Maintenance.ToList();

        }

        public MaintenanceModel GetMaintenanceById(int id)
        {

                return _context.Maintenance.Find(id);

    
        }

        public void RemoveMaintenance(int id)
        {

                var model = _context.Maintenance.Find(id);
                _context.Maintenance.Remove(model);
                _context.SaveChanges();
            
        }

        public void UpdateMaintenance(MaintenanceModel maintain)
        {
            
                _context.Maintenance.Update(maintain);
                _context.SaveChanges();


        }

        IEnumerable<MaintenanceModel> IMaintenanceRepository.GetMaintenanceByStatus(string status)
        {
            IEnumerable<MaintenanceModel> main = _context.Maintenance.ToList();
            return main.Where(main => main.MStatus == status).ToList();
        }

        IEnumerable<MaintenanceModel> IMaintenanceRepository.GetMaintenanceByType(string type)
        {
            IEnumerable<MaintenanceModel> main = _context.Maintenance.ToList();
            return main.Where(main => main.MType == type).ToList();
        }
    }
}
