using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity.Models
{
    public class TechnicianModel
    {
        [Key]
        public int TechId { get; set; }
        public string TechName { get; set; }
        public string TechPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TechType { get; set; }
    }
}
