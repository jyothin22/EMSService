using EMS.DAL.Repository;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BAL.Services
{
    public class TechnicianService
    {
        private ITechnicianrepository _Technician;
        public TechnicianService(ITechnicianrepository technician)
        {
            _Technician = technician;
        }
        public void AddTechnician(TechnicianModel tech)
        {
            _Technician.AddTechnician(tech);
        }
        public void RemoveTechnician(int id)
        {
            _Technician.RemoveTechnician(id);
        }
        public TechnicianModel GetTechnician(int id)
        {
            return _Technician.GetTechnicianById(id);
        }
        public void UpdateTechnician(TechnicianModel technician)
        {
            _Technician.UpdateTechnician(technician);
        }
        public IEnumerable<TechnicianModel> GetAll() 
        {
            return _Technician.GetAllTechnicians();
        }
    }
}
