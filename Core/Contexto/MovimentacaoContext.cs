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

namespace ISync.Core.Contexto
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
            modelBuilder.Entity<InfRespTec>().ToTable("tbMovInfRespTecs");
            modelBuilder.Entity<NFref>().ToTable("tbMovNFRefs");
            modelBuilder.Entity<Emit>().ToTable("tbMovEmits");
            modelBuilder.Entity<Dest>().ToTable("tbMovDests");
            modelBuilder.Entity<Prod>().ToTable("tbMovProds");
            modelBuilder.Entity<ICMS>().ToTable("tbMovProdIcms");
            modelBuilder.Entity<COFINS>().ToTable("tbMovProdCofins");
            modelBuilder.Entity<II>().ToTable("tbMovProdIis");
            modelBuilder.Entity<IPI>().ToTable("tbMovProdIpis");
            modelBuilder.Entity<PIS>().ToTable("tbMovProdPis");
            modelBuilder.Entity<ISSQN>().ToTable("tbMovProdISSQNs");
            modelBuilder.Entity<Comb>().ToTable("tbMovProdCombs");
            modelBuilder.Entity<Encerrante>().ToTable("tbMovProdCombEncerrantes");
            modelBuilder.Entity<DetExport>().ToTable("tbMovProdDetExports");
            modelBuilder.Entity<ExportInd>().ToTable("tbMovProdDetExportInds");
            modelBuilder.Entity<DI>().ToTable("tbMovProdDIs");
            modelBuilder.Entity<Adi>().ToTable("tbMovProdDIAdis");
            modelBuilder.Entity<ICMSTot>().ToTable("tbMovICMSTotais");
            modelBuilder.Entity<RetTrib>().ToTable("tbMovRetTribs");
            modelBuilder.Entity<ISSQNtot>().ToTable("tbMovISSQNTotais");
            modelBuilder.Entity<Transp>().ToTable("tbMovTransps");
            modelBuilder.Entity<Transporta>().ToTable("tbMovTransportas");
            modelBuilder.Entity<RetTransp>().ToTable("tbMovTranspRets");
            modelBuilder.Entity<VeicTransp>().ToTable("tbMovTranspVeics");
            modelBuilder.Entity<Reboque>().ToTable("tbMovTranspReboques");
            modelBuilder.Entity<Vol>().ToTable("tbMovTranspVols");
            modelBuilder.Entity<Lacre>().ToTable("tbMovTranspVolLacres");
            modelBuilder.Entity<DetPag>().ToTable("tbMovPagDets");
            modelBuilder.Entity<Card>().ToTable("tbMovPagDetCards");
            modelBuilder.Entity<Dup>().ToTable("tbMovDups");
            modelBuilder.Entity<Fat>().ToTable("tbMovFats");
            modelBuilder.Entity<RetiradaDocumento>().ToTable("tbRetiradaDocumentos");

            modelBuilder.Entity<Ide>()
            .HasMany(i => i.NFref)
            .WithOne(n => n.Ide)
            .HasForeignKey(n => n.IdeId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Comb>()
            .OwnsOne(c => c.OrigComb, ob =>
            {
                ob.Property(o => o.indImport).HasColumnName("OrigComb_IndImport");
                ob.Property(o => o.cUFOrig).HasColumnName("OrigComb_CUFOrig");
                ob.Property(o => o.pOrig).HasColumnName("OrigComb_POrig");
            });
        }
    }
}
