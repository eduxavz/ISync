using ISync.Classes.Core.Enums.Movimentacao;
using ISync.Entidades.Movimentacao.Detalhe;
using System;

namespace ISync.Entidades.Movimentacao.Detalhe.Tributacao.Federal
{
    public class COFINS : Base
    {
        /// <summary>
        /// Relacionamento Produto principal
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     S06 - Código de Situação Tributária da COFINS
        /// </summary>
        public CSTCOFINS CST { get; private set; }

        /// <summary>
        ///     S07 - Valor da Base de Cálculo da COFINS
        /// </summary>
        public decimal? VBC { get; private set; }

        /// <summary>
        ///     S08 - Alíquota da COFINS (em percentual)
        /// </summary>
        public decimal? PCOFINS { get; private set; }

        /// <summary>
        ///     S09 - Quantidade Vendida
        /// </summary>
        public decimal? QBCProd { get; private set; }

        /// <summary>
        ///     S10 - Alíquota da COFINS (em reais)
        /// </summary>
        public decimal? VAliqProd { get; private set; }

        /// <summary>
        ///     S11 - Valor da COFINS
        /// </summary>
        public decimal? VCOFINS { get; private set; }


        public virtual Prod Prod { get; private set; }


        protected COFINS() { }

        public COFINS(int id, int prodId, CSTCOFINS cST, decimal? vBC, decimal? pCOFINS, decimal? qBCProd, decimal? vAliqProd)
        {
            Id = id;
            ProdId = prodId;
            CST = cST;
            VBC = vBC;
            PCOFINS = pCOFINS;
            QBCProd = qBCProd;
            VAliqProd = vAliqProd;

            CalcularCofins();
        }

        public void Atualizar(decimal vBC)
        {
            VBC = vBC;

            CalcularCofins();
        }

        private void CalcularCofins()
        {
            switch (CST)
            {
                case CSTCOFINS.cofins01:
                case CSTCOFINS.cofins02:
                    CalcularCst01E02();
                    break;
                case CSTCOFINS.cofins03:
                    CalcularCst03();
                    break;
                default:
                    CalcularDefault();
                    break;
            }
        }

        private void CalcularCst01E02()
        {
            VCOFINS = VBC / 100 * PCOFINS;
        }

        private void CalcularCst03()
        {
            VCOFINS = QBCProd * VAliqProd;
        }

        private void CalcularDefault()
        {
            if (PCOFINS > decimal.Zero)
            {
                VCOFINS = VBC / 100 * PCOFINS;
            }
            else if (VAliqProd > decimal.Zero)
            {
                VCOFINS = QBCProd * VAliqProd;
            }
        }
    }
}