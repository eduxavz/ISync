using ISync.Entidades.Cadastros;
using ISync.Entidades.Cadastros.Parceiro;
using Microsoft.EntityFrameworkCore;

namespace ISync.Core.Contexto
{
    public class CadastroContext: DbContext
    {
        public DbSet<Parceiro> CadastroDados { get; set; }
        public DbSet<EmpresaDado> EmpresaDados { get; set; }
        public DbSet<NaturezaOperacao> NaturezaOperacao { get; set; }
        public DbSet<ProdutoDado> ProdutoDados { get; set; }
        public DbSet<Parceiro> ProdutoImpostos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=dbisync_fit;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parceiro>().ToTable("tbCadastroDados");
            modelBuilder.Entity<EmpresaDado>().ToTable("tbEmpresaDados");
            modelBuilder.Entity<NaturezaOperacao>().ToTable("tbNaturezaOperacao");
            modelBuilder.Entity<ProdutoDado>().ToTable("tbProdutoDados");
            modelBuilder.Entity<Imposto>().ToTable("tbProdutoImpostos");
        }
    }
}
