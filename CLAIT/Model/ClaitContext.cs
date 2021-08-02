using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLAIT.Model
{
    public class ClaitContext : DbContext
    {
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentCabinet> EquipmentsCabinets { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                //.UseSqlite(@"Data Source = E:\VSProjects\CLAIT\Database2\base.db")
                .UseSqlite(@"Data Source = .\Database\base.db")
                .UseLazyLoadingProxies();
        }
    }
}
