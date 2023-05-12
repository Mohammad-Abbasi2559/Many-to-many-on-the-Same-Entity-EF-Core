using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverFlowAnswer
{
    public class Db:DbContext
    {
        public Db() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(local);Database=StackOverFlow;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Mapped_SatationsMap());
        }

        DbSet<Mapped_Stations> Mapped_Stations { get; set; }
        DbSet<Station> stations { get; set; }
    }
}
