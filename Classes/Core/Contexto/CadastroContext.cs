using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Classes.Core.Contexto
{
    public class CadastroContext: DbContext
    {
        public DbSet<tbCadastroDados> Cadastros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\ISyncBD;Integrated Security=true;Database=db_isync;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbCadastroDados>().ToTable("tbCadastroDados");
            // você pode configurar colunas aqui se quiser com .Property(x => x.Nome).HasMaxLength(100);
        }
    }
}
