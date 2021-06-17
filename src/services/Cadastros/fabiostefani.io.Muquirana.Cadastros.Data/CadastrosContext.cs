using System;
using System.Linq;
using System.Threading.Tasks;
using fabiostefani.io.Muquirana.Cadastros.Domain.Categorias;
using fabiostefani.io.Muquirana.Cadastros.Domain.Categorias.Subcategorias;
using Microsoft.EntityFrameworkCore;

namespace fabiostefani.io.Muquirana.Cadastros.Data
{
    public class CadastrosContext : DbContext
    {
        public CadastrosContext(DbContextOptions<CadastrosContext> options) : base (options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Subcategoria> Subcategorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p=>p.ClrType == typeof(string)))) 
            {
                property.SetColumnType("varchar(100)");
            }
                
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CadastrosContext).Assembly);
            //base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            foreach ( var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                TratarDataCadastro(entry);
                TratarDataAlteracao(entry);
            }

            return await base.SaveChangesAsync() > 0;
        }

        private static void TratarDataAlteracao(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
            }

            if (entry.State == EntityState.Added)
            {
                entry.Property("DataAlteracao").IsModified = false;
            }
        }

        private static void TratarDataCadastro(Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry entry)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Property("DataCadastro").CurrentValue = DateTime.Now;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Property("DataCadastro").IsModified = false;
            }
        }
    }
}