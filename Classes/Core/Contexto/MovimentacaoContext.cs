using ISync.Entidades.Cadastro;
using ISync.Entidades.Cadastros;
using ISync.Entidades.Movimentacao.Identificacao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Classes.Core.Contexto
{
    public class MovimentacaoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\ISyncBD;Integrated Security=true;Database=db_isync;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ide>().ToTable("tbMovDados");
            modelBuilder.Entity<tbEmpresaDados>().ToTable("tbEmpresaDados");
            modelBuilder.Entity<tbNaturezaOperacao>().ToTable("tbNaturezaOperacao");
            modelBuilder.Entity<tbProdutoDados>().ToTable("tbProdutoDados");
            modelBuilder.Entity<tbProdutoImpostos>().ToTable("tbProdutoImpostos");
        }
    }
}
