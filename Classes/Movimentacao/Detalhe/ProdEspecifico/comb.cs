using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe.ProdEspecifico
{
    public class Comb : Base
    {
        /// <summary>
        /// Relacionamento Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     LA02 - Código de produto da ANP
        /// Versão 3.00
        /// Versão 4.00
        /// </summary>
        public string CProdANP { get; private set; }

        /// <summary>
        ///     LA03 - Percentual de Gás Natural para o produto GLP (cProdANP=210203001)
        /// Versão 3.00
        /// </summary>
        public decimal? PMixGN { get; private set; }

        /// <summary>
        /// LA03 - Descrição do produto conforme ANP
        /// Versão 4.00
        /// </summary>
        public string DescANP { get; private set; }

        /// <summary>
        /// LA03a - Percentual do GLP derivado do petróleo no produto GLP (cProdANP=210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PGLP { get; private set; }

        /// <summary>
        /// LA03b - Percentual de Gás Natural Nacional – GLGNn para o produto GLP (cProdANP= 210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PGNn { get; private set; }

        /// <summary>
        /// LA03c - Percentual de Gás Natural Importado – GLGNi para o produto GLP (cProdANP= 210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? PGNi { get; private set; }

        /// <summary>
        /// LA03d - Valor de partida (cProdANP=210203001)
        /// Versão 4.00
        /// </summary>
        public decimal? VPart { get; private set; }

        /// <summary>
        ///     LA04 - Código de autorização / registro do CODIF
        /// </summary>
        public string CODIF { get; private set; }

        /// <summary>
        ///     LA05 - Quantidade de combustível faturada à temperatura ambiente
        /// </summary>
        public decimal? QTemp { get; private set; }

        /// <summary>
        ///     LA06 - Sigla da UF de consumo
        /// </summary>
        public string UFCons { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Prod Prod { get; private set; }
        public virtual ICollection<Encerrante> Encerrantes { get; private set; }


        protected Comb() { }

        public Comb(int id, int prodId, string cProdANP, decimal? pMixGN, string descANP, decimal? pGLP, decimal? pGNn, decimal? pGNi, decimal? vPart, string cODIF, decimal? qTemp, string uFCons)
        {
            Id = id;
            ProdId = prodId;
            CProdANP = cProdANP;
            PMixGN = pMixGN;
            DescANP = descANP;
            PGLP = pGLP;
            PGNn = pGNn;
            PGNi = pGNi;
            VPart = vPart;
            CODIF = cODIF;
            QTemp = qTemp;
            UFCons = uFCons;
        }

        public void AdicionarEncerrante(Encerrante encerrante)
        {
            if (Encerrantes == null) Encerrantes = new List<Encerrante>();

            Encerrantes.Add(encerrante);
        }
    }
}