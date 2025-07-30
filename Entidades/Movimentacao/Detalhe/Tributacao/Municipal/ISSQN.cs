using Infotech.PDV.Movimentacao.Domain.Entities.Detalhe.Tributacao.Municipal;
using ISync.Entidades.Movimentacao.Detalhe;
using System;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Detalhe.Tributacao.Municipal
{
    public class ISSQN : Base
    {
        /// <summary>
        /// Relacionamento o Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     U02 - Valor da Base de Cálculo do ISSQN
        /// </summary>
        public decimal VBC { get; private set; }

        /// <summary>
        ///     U03 - Alíquota do ISSQN
        /// </summary>
        public decimal VAliq { get; private set; }

        /// <summary>
        ///     U04 - Valor do ISSQN
        /// </summary>
        public decimal VISSQN { get; private set; }

        /// <summary>
        ///     U05 - Código do município de ocorrência do fato gerador do ISSQN
        /// </summary>
        public long CMunFG { get; private set; }

        /// <summary>
        ///     U06 - Item da Lista de Serviços
        /// </summary>
        public string CListServ { get; private set; }

        /// <summary>
        ///     U07 - Valor dedução para redução da Base de Cálculo
        /// </summary>
        public decimal? VDeducao { get; private set; }

        /// <summary>
        ///     U08 - Valor outras retenções
        /// </summary>
        public decimal? VOutro { get; private set; }

        /// <summary>
        ///     U09 - Valor desconto incondicionado
        /// </summary>
        public decimal? VDescIncond { get; private set; }

        /// <summary>
        ///     U10 - Valor desconto condicionado
        /// </summary>
        public decimal? VDescCond { get; private set; }

        /// <summary>
        ///     U11 - Valor retenção ISS
        /// </summary>
        public decimal? VISSRet { get; private set; }

        /// <summary>
        ///     U12 - Indicador da exigibilidade do ISS
        /// </summary>
        public IndicadorISS? IndISS { get; private set; }

        /// <summary>
        ///     U13 - Código do serviço prestado dentro do município
        /// </summary>
        public string CServico { get; private set; }

        /// <summary>
        ///     U14 - Código do Município de incidência do imposto
        /// </summary>
        public long? CMun { get; private set; }

        /// <summary>
        ///     U15 - Código do País onde o serviço foi prestado
        /// </summary>
        public int? CPais { get; private set; }

        /// <summary>
        ///     U16 - Número do processo judicial ou administrativo de suspensão da exigibilidade
        /// </summary>
        public string NProcesso { get; private set; }

        /// <summary>
        ///     U17 - Indicador de incentivo Fiscal
        /// </summary>
        public indIncentivo? IndIncentivo { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Prod Prod { get; private set; }


        protected ISSQN() { }

        public ISSQN(int id, int prodId, decimal vBC, decimal vAliq, decimal vISSQN, long cMunFG, string cListServ, decimal? vDeducao, decimal? vOutro, decimal? vDescIncond, decimal? vDescCond, decimal? vISSRet, IndicadorISS? indISS, string cServico, long? cMun, int? cPais, string nProcesso, indIncentivo? indIncentivo)
        {
            Id = id;
            ProdId = prodId;
            VBC = vBC;
            VAliq = vAliq;
            VISSQN = vISSQN;
            CMunFG = cMunFG;
            CListServ = cListServ;
            VDeducao = vDeducao;
            VOutro = vOutro;
            VDescIncond = vDescIncond;
            VDescCond = vDescCond;
            VISSRet = vISSRet;
            IndISS = indISS;
            CServico = cServico;
            CMun = cMun;
            CPais = cPais;
            NProcesso = nProcesso;
            IndIncentivo = indIncentivo;
        }
    }
}