using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class YanbalDbContext: DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.use
        //}
        public YanbalDbContext(DbContextOptions<YanbalDbContext> options ): base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfiguration(new ClienteEntityTypeConfiguration());
        }
    
    }

    public class ClienteEntityTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {

        public void Configure(EntityTypeBuilder<Cliente> builder) 
        {
                                    
            builder.Property(x => x.Nombres).HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();
            builder.Property(x => x.Apellidos).HasColumnType("VARCHAR").HasMaxLength(250).IsRequired();            
            builder.Property(x => x.Correo).HasColumnType("VARCHAR").HasMaxLength(320).IsRequired();
            builder.Property(x => x.Direccion).HasColumnType("VARCHAR").HasMaxLength(800).IsRequired(false);
            builder.Property(x => x.Activo).IsRequired().HasDefaultValue(true);
            

            builder.HasKey(x => x.Id);



        }
    }
}
