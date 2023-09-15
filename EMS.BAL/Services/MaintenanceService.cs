using EMS.DAL.Repository;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BAL.Services
{
    public class MaintenanceService
    {
        IMaintenanceRepository _MaintainRepository;
        public MaintenanceService(IMaintenanceRepository maintenanceRepository)
        {
            _MaintainRepository = maintenanceRepository;
        }
        public string AddMaintenance(MaintenanceModel model)
        {
           return  _MaintainRepository.AddMaintenance(model);
        }
        public void DeleteMaintenance(int id) 
        {
            _MaintainRepository.RemoveMaintenance(id);
        }
        public IEnumerable<MaintenanceModel> GetAll() 
        {
            return _MaintainRepository.GetAll();    
        }
        public IEnumerable<MaintenanceModel> GetMaintenanceByStatus(string status)
        {
            return _MaintainRepository.GetMaintenanceByStatus(status);
        }
        public IEnumerable<MaintenanceModel> GetMaintenanceByType(string type)
        {
            return _MaintainRepository.GetMaintenanceByType(type);
        }
        public MaintenanceModel GetMaintenance(int id) 
        {
            return _MaintainRepository.GetMaintenanceById(id);
        }
        public void UpdateMaintenanceModel(MaintenanceModel model) 
        {
            _MaintainRepository.UpdateMaintenance(model);
        }
    }
}
