using EMS.DAL.Data;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public class TechnicianRepository : ITechnicianrepository
    {
        EMSDbContext _context;
        public TechnicianRepository(EMSDbContext context )
        {
            _context = context;
        }
        public void AddTechnician(TechnicianModel tech)
        {
  
                _context.Technician.Add(tech);
                _context.SaveChanges();

        }

        public IEnumerable<TechnicianModel> GetAllTechnicians()
        {

                return _context.Technician.ToList();
  
   
        }

        public TechnicianModel GetTechnicianById(int id)
        {
     
                return _context.Technician.Find(id);
     

        }

        public void RemoveTechnician(int id)
        {
       
                var technician = _context.Technician.Find(id);
                _context.Technician.Remove(technician);
                _context.SaveChanges();

        } 

        public void UpdateTechnician(TechnicianModel tech)
        {

                _context.Technician.Update(tech);
                _context.SaveChanges();



        }
    }
}
