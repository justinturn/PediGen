using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PediGen.Models
{
    class PedigreeContext : DbContext 
    {
        public PedigreeContext()
        {
            Database.SetInitializer<PedigreeContext>(new CreateDatabaseIfNotExists<PedigreeContext>());

        }
        public DbSet<Pig> Pigs { get; set; }
        public DbSet<Breeder> Breeders { get; set; }
        public DbSet<Litter> Litters { get; set; }

    }
}
