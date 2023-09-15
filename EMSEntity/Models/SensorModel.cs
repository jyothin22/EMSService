using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity.Models
{
    public  class SensorModel
    {
        [Key]
        public int SensorId { get; set; }
        public int EqId { get; set; }
        public string STimeStamp { get; set; }
        public float STemperature { get; set; }
        public float SPressure { get; set; }
        public float SVibration { get; set; }
    }
}
