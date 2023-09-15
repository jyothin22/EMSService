using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity.Models
{
    public class EquipmentModel
    {
        [Key]
        public int EqId { get; set; }
        public string EqName { get; set; }
        public string EqDate { get; set; }
        public string EqStatus { get; set; }
        public string EqLocation { get; set; }
        public string EqType { get; set; }
    }
}
