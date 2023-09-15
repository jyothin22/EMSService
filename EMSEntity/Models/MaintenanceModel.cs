using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity.Models
{
    public class MaintenanceModel
    {
        [Key]
        public int MaintenanceId {get;set;}

        public int EqId { get; set; }
        public string MTimeStamp { get;set;}
        public string MType { get;set;}
        public string MDesc { get;set;}
        public int TechId { get; set; }
        public string MStatus { get; set; }
    }
}
