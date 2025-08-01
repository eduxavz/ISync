using ISync.Entidades.Cadastros;
using Microsoft.EntityFrameworkCore;

namespace ISync.Classes.Core.Contexto
{
    public class CadastroContext: DbContext
    {
        public DbSet<tbCadastroDados> CadastroDados { get; set; }
        public DbSet<tbEmpresaDados> EmpresaDados { get; set; }
        public DbSet<tbNaturezaOperacao> NaturezaOperacao { get; set; }
        public DbSet<tbProdutoDados> ProdutoDados { get; set; }
        public DbSet<tbCadastroDados> ProdutoImpostos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\ISyncBD;Integrated Security=true;Database=db_isync;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbCadastroDados>().ToTable("tbCadastroDados");
            modelBuilder.Entity<tbEmpresaDados>().ToTable("tbEmpresaDados");
            modelBuilder.Entity<tbNaturezaOperacao>().ToTable("tbNaturezaOperacao");
            modelBuilder.Entity<tbProdutoDados>().ToTable("tbProdutoDados");
            modelBuilder.Entity<tbProdutoImpostos>().ToTable("tbProdutoImpostos");
        }
    }
}
