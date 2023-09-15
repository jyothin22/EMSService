using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity.Models
{
    public class AnamolyModel
    {
        [Key]
        public int AId { get; set; }

        public int EqId { get; set; }

        public string ATimeStamp { get; set; }
        public string AType { get; set; }
        public string ASeverity { get; set; }
    }
}