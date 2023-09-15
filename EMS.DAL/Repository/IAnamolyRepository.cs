using EMSEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.Repository
{
    public interface IAnamolyRepository
    {
        string AddAnamoly(AnamolyModel anamoly);
        void UpdateAnamoly(AnamolyModel anamoly);
        void DeleteAnamoly(int id);
        IEnumerable<AnamolyModel> GetAllAnamoly();
        AnamolyModel GetAnamolyById(int id);
    }
}
