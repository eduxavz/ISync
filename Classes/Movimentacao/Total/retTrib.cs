using ISync.Classes.Movimentacao.Movimentacao.Identificacao;
using System;

namespace ISync.Classes.Movimentacao.Movimentacao.Total
{
    public class RetTrib : Base
    {
        public int IdeId { get; private set; }

        /// <summary>
        ///     W24 - Valor Retido de PIS
        /// </summary>
        public decimal? VRetPIS { get; private set; }

        /// <summary>
        ///     W25 - Valor Retido de COFINS
        /// </summary>
        public decimal? VRetCOFINS { get; private set; }

        /// <summary>
        ///     W26 - Valor Retido de CSLL
        /// </summary>
        public decimal? VRetCSLL { get; private set; }

        /// <summary>
        ///     W27 - Base de Cálculo do IRRF
        /// </summary>
        public decimal? VBCIRRF { get; private set; }

        /// <summary>
        ///     W28 - Valor Retido do IRRF
        /// </summary>
        public decimal? VIRRF { get; private set; }

        /// <summary>
        ///     W29 - Base de Cálculo da Retenção da Previdência Social
        /// </summary>
        public decimal? VBCRetPrev { get; private set; }

        /// <summary>
        ///     W30 - Valor da Retenção da Previdência Social
        /// </summary>
        public decimal? VRetPrev { get; private set; }

        public virtual Ide Ide { get; private set; }


        protected RetTrib() { }

        public RetTrib(int id, int ideId, decimal? vRetPIS, decimal? vRetCOFINS, decimal? vRetCSLL, decimal? vBCIRRF, decimal? vIRRF, decimal? vBCRetPrev, decimal? vRetPrev)
        {
            Id = id;
            IdeId = ideId;
            VRetPIS = vRetPIS;
            VRetCOFINS = vRetCOFINS;
            VRetCSLL = vRetCSLL;
            VBCIRRF = vBCIRRF;
            VIRRF = vIRRF;
            VBCRetPrev = vBCRetPrev;
            VRetPrev = vRetPrev;
        }
    }
}