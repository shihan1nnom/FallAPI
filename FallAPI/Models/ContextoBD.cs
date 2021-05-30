using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FallAPI.Models
{
    public class ContextoBD: DbContext
    {
        public ContextoBD() : base("BD_FALL") { } // Especifica nombre de conexion string

        public DbSet<Dato> Datos { get; set; }
        public DbSet<Cancelacion> Cancelaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cancelacion>().ToTable("Cancelacion");
            modelBuilder.Entity<Dato>().ToTable("Dato");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}