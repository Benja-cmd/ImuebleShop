using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApiGlobal.Models;

namespace WebApiGlobal
{
    public partial class CursoWEBAPIContext : DbContext
    {
        public CursoWEBAPIContext()
        {
        }

        public CursoWEBAPIContext(DbContextOptions<CursoWEBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Sale>  Sales { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Condition> Condicions { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Payament> Payaments { get; set; }
        public DbSet<TypeFurniture> TipeFurnitures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-89NRS76\\SQLEXPRESS; Database=CursoWEBAPI; Integrated Security=True; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
