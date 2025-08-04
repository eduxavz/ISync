using ISync.Entidades.Cadastros;
using ISync.Entidades.Movimentacao.Cobranca;
using ISync.Entidades.Movimentacao.Destinatario;
using ISync.Entidades.Movimentacao.Detalhe;
using ISync.Entidades.Movimentacao.Detalhe.DeclaracaoImportacao;
using ISync.Entidades.Movimentacao.Detalhe.Exportacao;
using ISync.Entidades.Movimentacao.Detalhe.ProdEspecifico;
using ISync.Entidades.Movimentacao.Detalhe.Tributacao.Estadual;
using ISync.Entidades.Movimentacao.Detalhe.Tributacao.Federal;
using ISync.Entidades.Movimentacao.Detalhe.Tributacao.Municipal;
using ISync.Entidades.Movimentacao.Emitente;
using ISync.Entidades.Movimentacao.Identificacao;
using ISync.Entidades.Movimentacao.Intermediador;
using ISync.Entidades.Movimentacao.Pagamento;
using ISync.Entidades.Movimentacao.RespTecnico;
using ISync.Entidades.Movimentacao.Retirada;
using ISync.Entidades.Movimentacao.Total;
using ISync.Entidades.Movimentacao.Transporte;
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
        public DbSet<Ide> MovIdes { get; set; }
        public DbSet<InfIntermed> MovInfIntermed { get; set; }
        public DbSet<InfRespTec> MovInfRespTecs { get; set; }
        public DbSet<NFref> MovNFRefs { get; set; }
        public DbSet<Emit> MovEmits { get; set; }
        public DbSet<Dest> MovDests { get; set; }
        public DbSet<Prod> MovProds { get; set; }
        public DbSet<ICMS> MovProdIcms { get; set; }
        public DbSet<COFINS> MovProdCofins { get; set; }
        public DbSet<II> MovProdIis { get; set; }
        public DbSet<IPI> MovProdIpis { get; set; }
        public DbSet<PIS> MovProdPis { get; set; }
        public DbSet<ISSQN> MovProdISSQNs { get; set; }
        public DbSet<Comb> MovProdCombs { get; set; }
        public DbSet<OrigComb> MovProdCombOrigCombs { get; set; }
        public DbSet<Encerrante> MovProdCombEncerrantes { get; set; }
        public DbSet<DetExport> MovProdDetExports { get; set; }
        public DbSet<ExportInd> MovProdDetExportInds { get; set; }
        public DbSet<DI> MovProdDIs { get; set; }
        public DbSet<Adi> MovProdDIAdis { get; set; }
        public DbSet<ICMSTot> MovICMSTotais { get; set; }
        public DbSet<RetTrib> MovRetTribs { get; set; }
        public DbSet<ISSQNtot> MovISSQNTotais { get; set; }
        public DbSet<Transp> MovTransps { get; set; }
        public DbSet<Transporta> MovTransportas { get; set; }
        public DbSet<RetTransp> MovTranspRets { get; set; }
        public DbSet<VeicTransp> MovTranspVeics { get; set; }
        public DbSet<Reboque> MovTranspReboques { get; set; }
        public DbSet<Vol> MovTranspVols { get; set; }
        public DbSet<Lacre> MovTranspVolLacres { get; set; }
        public DbSet<DetPag> MovPagDets { get; set; }
        public DbSet<Card> MovPagDetCards { get; set; }
        public DbSet<Dup> MovDups { get; set; }
        public DbSet<Fat> MovFats { get; set; }
        public DbSet<RetiradaDocumento> RetiradaDocumentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\ISyncBD;Integrated Security=true;Database=db_isync;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ide>().ToTable("tbMovDados");
            modelBuilder.Entity<InfIntermed>().ToTable("tbMovInfIntermed");
            modelBuilder.Entity<InfRespTec>().ToTable("MovInfRespTecs");
            modelBuilder.Entity<NFref>().ToTable("MovNFRefs");
            modelBuilder.Entity<Emit>().ToTable("MovEmits");
            modelBuilder.Entity<Dest>().ToTable("MovDests");
            modelBuilder.Entity<Prod>().ToTable("MovProds");
            modelBuilder.Entity<ICMS>().ToTable("MovProdIcms");
            modelBuilder.Entity<COFINS>().ToTable("MovProdCofins");
            modelBuilder.Entity<II>().ToTable("MovProdIis");
            modelBuilder.Entity<IPI>().ToTable("MovProdIpis");
            modelBuilder.Entity<PIS>().ToTable("MovProdPis");
            modelBuilder.Entity<ISSQN>().ToTable("MovProdISSQNs");
            modelBuilder.Entity<Comb>().ToTable("MovProdCombs");
            modelBuilder.Entity<OrigComb>().ToTable("MovProdCombOrigCombs");
            modelBuilder.Entity<Encerrante>().ToTable("MovProdCombEncerrantes");
            modelBuilder.Entity<DetExport>().ToTable("MovProdDetExports");
            modelBuilder.Entity<ExportInd>().ToTable("MovProdDetExportInds");
            modelBuilder.Entity<DI>().ToTable("MovProdDIs");
            modelBuilder.Entity<Adi>().ToTable("MovProdDIAdis");
            modelBuilder.Entity<ICMSTot>().ToTable("MovICMSTotais");
            modelBuilder.Entity<RetTrib>().ToTable("MovRetTribs");
            modelBuilder.Entity<ISSQNtot>().ToTable("MovISSQNTotais");
            modelBuilder.Entity<Transp>().ToTable("MovTransps");
            modelBuilder.Entity<Transporta>().ToTable("MovTransportas");
            modelBuilder.Entity<RetTransp>().ToTable("MovTranspRets");
            modelBuilder.Entity<VeicTransp>().ToTable("MovTranspVeics");
            modelBuilder.Entity<Reboque>().ToTable("MovTranspReboques");
            modelBuilder.Entity<Vol>().ToTable("MovTranspVols");
            modelBuilder.Entity<Lacre>().ToTable("MovTranspVolLacres");
            modelBuilder.Entity<DetPag>().ToTable("MovPagDets");
            modelBuilder.Entity<Card>().ToTable("MovPagDetCards");
            modelBuilder.Entity<Dup>().ToTable("MovDups");
            modelBuilder.Entity<Fat>().ToTable("MovFats");
            modelBuilder.Entity<RetiradaDocumento>().ToTable("RetiradaDocumentos");
        }
    }
}
