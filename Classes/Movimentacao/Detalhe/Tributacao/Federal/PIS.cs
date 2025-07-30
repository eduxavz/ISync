
using ISync.Classes.Core.Enums.Movimentacao;
using System.Text.Json.Serialization;

namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe.Tributacao.Federal
{
    public class PIS : Base
    {
        /// <summary>
        /// Relacionamento Produto principal
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     Q06 - Código de Situação Tributária do PIS
        /// </summary>
        public CSTPIS CST { get; private set; }

        /// <summary>
        ///     Q07 - Valor da Base de Cálculo do PIS
        /// </summary>
        public decimal VBC { get; private set; }

        /// <summary>
        ///     Q08 - Alíquota do PIS (em percentual)
        /// </summary>
        public decimal PPIS { get; private set; }

        /// <summary>
        ///     Q09 - Valor do PIS
        /// </summary>
        public decimal VPIS { get; private set; }

        /// <summary>
        ///     Q10 - Quantidade Vendida
        /// </summary>
        public decimal? QBCProd { get; private set; }

        /// <summary>
        ///     Q11 - Alíquota do PIS (em reais)
        /// </summary>
        public decimal? VAliqProd { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Prod Prod { get; private set; }


        public PIS() { }

        public PIS(int id, int prodId, CSTPIS cST, decimal vBC, decimal pPIS, decimal? qBCProd, decimal? vAliqProd)
        {
            Id = id;
            ProdId = prodId;
            CST = cST;
            VBC = vBC;
            PPIS = pPIS;
            QBCProd = qBCProd;
            VAliqProd = vAliqProd;

            CalcularPis();
        }

        public void Atualizar(decimal vBC)
        {
            VBC = vBC;

            CalcularPis();
        }

        private void CalcularPis()
        {
            switch (CST)
            {
                case CSTPIS.pis01:
                case CSTPIS.pis02:
                    CalcularCst01E02();
                    break;
                case CSTPIS.pis03:
                    CalcularCst03();
                    break;
                default:
                    CalcularDefault();
                    break;
            }
        }

        private void CalcularCst01E02()
        {
            VPIS = VBC / 100 * PPIS;
        }

        private void CalcularCst03()
        {
            if (VAliqProd > decimal.Zero)
            {
                VPIS = QBCProd.Value * VAliqProd.Value;
            }
        }

        private void CalcularDefault()
        {
            if (PPIS > decimal.Zero)
            {
                VPIS = VBC / 100 * PPIS;
            }
            else if (VAliqProd > decimal.Zero)
            {
                VPIS = QBCProd.Value * VAliqProd.Value;
            }
        }


    }
}