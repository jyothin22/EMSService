using EMSEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EMS.DAL.Data
{
    public class EMSDbContext:DbContext
    {
          public EMSDbContext(DbContextOptions<EMSDbContext> options) : base(options) 
        { }
        public DbSet<EquipmentModel> Equipment { get; set; }
        public DbSet<SensorModel> Sensor { get; set; }
        public DbSet<MaintenanceModel> Maintenance { get; set; }
        public DbSet<TechnicianModel> Technician { get; set;}
        public DbSet<AnamolyModel> Anamoly { get; set; }
    }
}
