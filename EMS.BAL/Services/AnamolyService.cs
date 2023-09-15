using EMS.DAL.Repository;
using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BAL.Services
{
    public class AnamolyService
    {
        IAnamolyRepository _AnamolyRepository;
        public AnamolyService(IAnamolyRepository AnamolyRepository)
        {
            _AnamolyRepository = AnamolyRepository;
        }
        public string AddAnamoly(AnamolyModel anamoly)
        {
           return  _AnamolyRepository.AddAnamoly(anamoly);
        }

        public IEnumerable<AnamolyModel> GetAllAnamoly() 
        {
            return _AnamolyRepository.GetAllAnamoly();
        }
        public AnamolyModel GetAnamolyById(int id)
        {
            return _AnamolyRepository.GetAnamolyById(id);
        }

        public void UpdateAnamoly(AnamolyModel anamoly)
        {
            _AnamolyRepository.UpdateAnamoly(anamoly);
        }

        public void DeleteAnamoly(int id)
        {
            _AnamolyRepository.DeleteAnamoly(id);
        }
    }
}