using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.Context
{
    public class BoletoBusContext : DbContext
    {
        #region"Constructor"
        public BoletoBusContext(DbContextOptions<BoletoBusContext> options)
            : base(options)
        {
        }
        #endregion

        #region"DbSets"

        public DbSet<Domain.Entities.Ruta> Ruta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.Ruta>(entity =>
            {
                entity.HasKey(e => e.IdRuta);
            });
        }
        #endregion
    }
}