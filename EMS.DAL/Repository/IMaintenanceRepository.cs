using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public interface IMaintenanceRepository
    {
        string AddMaintenance(MaintenanceModel maintain);
        void UpdateMaintenance(MaintenanceModel maintain);
        void RemoveMaintenance(int id);
        MaintenanceModel GetMaintenanceById(int id);
        IEnumerable<MaintenanceModel> GetAll();
        IEnumerable<MaintenanceModel> GetMaintenanceByStatus(string status);

        IEnumerable<MaintenanceModel> GetMaintenanceByType(string type);
    }
}
