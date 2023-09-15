using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public interface ITechnicianrepository
    {
        void AddTechnician(TechnicianModel tech);
        void RemoveTechnician(int id);
        void UpdateTechnician(TechnicianModel tech);
        TechnicianModel GetTechnicianById(int id);
        IEnumerable<TechnicianModel> GetAllTechnicians();
    }
}
