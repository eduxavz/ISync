using ISync.Entidades.Movimentacao.Identificacao;
using System;

namespace ISync.Entidades.Movimentacao.Total
{
    public class ISSQNtot : Base
    {
        /// <summary>
        /// Relacionamento Ide
        /// </summary>
        public int IdeId { get; private set; }

        /// <summary>
        ///     W18 - Valor total dos Serviços sob não-incidência ou não tributados pelo ICMS
        /// </summary>
        public decimal? VServ { get; private set; }

        /// <summary>
        ///     W19 - Valor total Base de Cálculo do ISS
        /// </summary>
        public decimal? VBC { get; private set; }

        /// <summary>
        ///     W20 - Valor total do ISS
        /// </summary>
        public decimal? VISS { get; private set; }

        /// <summary>
        ///     W21 - Valor total do PIS sobre serviços
        /// </summary>
        public decimal? VPIS { get; private set; }

        /// <summary>
        ///     W22 - Valor total da COFINS sobre serviços
        /// </summary>
        public decimal? VCOFINS { get; private set; }

        /// <summary>
        ///     W22a - Data da prestação do serviço
        /// </summary>
        public string DCompet { get; private set; }

        /// <summary>
        ///     W22b - Valor total dedução para redução da Base de Cálculo
        /// </summary>
        public decimal? VDeducao { get; private set; }

        /// <summary>
        ///     W22c - Valor total outras retenções
        /// </summary>
        public decimal? VOutro { get; private set; }

        /// <summary>
        ///     W22d - Valor total desconto incondicionado
        /// </summary>
        public decimal? VDescIncond { get; private set; }

        /// <summary>
        ///     W22e - Valor total desconto condicionado
        /// </summary>
        public decimal? VDescCond { get; private set; }

        /// <summary>
        ///     W22f - Valor total retenção ISS
        /// </summary>
        public decimal? VISSRet { get; private set; }

        /// <summary>
        ///     W22g - Código do Regime Especial de Tributação
        /// </summary>
        public RegTribISSQN? CRegTrib { get; private set; }


        public virtual Ide Ide { get; private set; }


        protected ISSQNtot() { }

        public ISSQNtot(int id, int ideId, decimal? vServ, decimal? vBC, decimal? vISS, decimal? vPIS, decimal? vCOFINS, string dCompet, decimal? vDeducao, decimal? vOutro, decimal? vDescIncond, decimal? vDescCond, decimal? vISSRet, RegTribISSQN? cRegTrib)
        {
            Id = id;
            IdeId = ideId;
            VServ = vServ;
            VBC = vBC;
            VISS = vISS;
            VPIS = vPIS;
            VCOFINS = vCOFINS;
            DCompet = dCompet;
            VDeducao = vDeducao;
            VOutro = vOutro;
            VDescIncond = vDescIncond;
            VDescCond = vDescCond;
            VISSRet = vISSRet;
            CRegTrib = cRegTrib;
        }
    }
}