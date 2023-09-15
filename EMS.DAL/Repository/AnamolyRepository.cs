using EMS.DAL.Data;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public class AnamolyRepository : IAnamolyRepository
    {
        EMSDbContext _context;
        public AnamolyRepository(EMSDbContext context)
        {
            _context = context;
        }
        public string AddAnamoly(AnamolyModel anamoly)
        {
            EquipmentModel equip = _context.Equipment.Find(anamoly.EqId);
            if (equip == null) 
            {
                return "The equipment is not there in the equipment  table ";
            }
            else
            {
                _context.Anamoly.Add(anamoly);
                _context.SaveChanges();
                return "Inserted Anamoly";
            }

        }
        
        public void DeleteAnamoly(int id)
        {

                var element = _context.Anamoly.Find(id);
                _context.Anamoly.Remove(element);
                _context.SaveChanges();
        }

        public AnamolyModel GetAnamolyById(int id)
        {

                return _context.Anamoly.Find(id);
           
        }

        public void UpdateAnamoly(AnamolyModel anamoly)
        {

                _context.Anamoly.Update(anamoly);
                _context.SaveChanges();
        }

        IEnumerable<AnamolyModel> IAnamolyRepository.GetAllAnamoly()
        {
            return _context.Anamoly.ToList();
        }
    }
}