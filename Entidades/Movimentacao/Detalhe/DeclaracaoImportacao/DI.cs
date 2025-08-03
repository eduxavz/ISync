
using Infotech.PDV.Movimentacao.Domain.Entities.Detalhe;
using ISync.Classes;

namespace ISync.Entidades.Movimentacao.Detalhe.DeclaracaoImportacao
{
    public class DI : Base
    {
        /// <summary>
        /// Relacionamento Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     I19 - Número do Documento de Importação (DI, DSI, DIRE, ...)
        /// </summary>
        public string NDI { get; private set; }

        /// <summary>
        ///     I20 - Data de Registro do documento.
        /// </summary>
        public DateTime DDI { get; private set; }

        /// <summary>
        ///     I21 - Local de desembaraço
        /// </summary>
        public string XLocDesemb { get; private set; }

        /// <summary>
        ///     I22 - Sigla da UF onde ocorreu o Desembaraço Aduaneiro
        /// </summary>
        public string UFDesemb { get; private set; }

        /// <summary>
        ///     I23 - Data do Desembaraço Aduaneiro.
        /// </summary>
        public DateTime DDesemb { get; private set; }

        /// <summary>
        ///     I23a - Via de transporte internacional informada na Declaração de Importação (DI)
        /// </summary>
        public TipoTransporteInternacional TpViaTransp { get; private set; }

        /// <summary>
        ///     I23b - Valor da AFRMM - Adicional ao Frete para Renovação da Marinha Mercante
        /// </summary>
        public decimal? VAFRMM { get; private set; }

        /// <summary>
        ///     I23c - Forma de importação quanto a intermediação
        /// </summary>
        public TipoIntermediacao TpIntermedio { get; private set; }

        /// <summary>
        ///     I23d - CNPJ do adquirente ou do encomendante
        /// </summary>
        public string CNPJ { get; private set; }

        /// <summary>
        ///     I23e - Sigla da UF do adquirente ou do encomendante
        /// </summary>
        public string UFTerceiro { get; private set; }

        /// <summary>
        ///     I24 - Código do Exportador
        /// </summary>
        public string CExportador { get; private set; }


        //EF Relacionamento
        public virtual Prod Prod { get; private set; }
        public virtual ICollection<Adi> Adis { get; private set; }

        protected DI() { }

        public DI(int id, int prodId, string nDI, DateTime dDI, string xLocDesemb, string uFDesemb, DateTime dDesemb, TipoTransporteInternacional tpViaTransp, decimal? vAFRMM, TipoIntermediacao tpIntermedio, string cNPJ, string uFTerceiro, string cExportador)
        {
            Id = id;
            ProdId = prodId;
            NDI = nDI;
            DDI = dDI;
            XLocDesemb = xLocDesemb;
            UFDesemb = uFDesemb;
            DDesemb = dDesemb;
            TpViaTransp = tpViaTransp;
            VAFRMM = vAFRMM;
            TpIntermedio = tpIntermedio;
            CNPJ = cNPJ;
            UFTerceiro = uFTerceiro;
            CExportador = cExportador;
        }
    }
}