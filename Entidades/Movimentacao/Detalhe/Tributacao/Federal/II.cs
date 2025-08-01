using ISync.Classes;
using ISync.Entidades.Movimentacao.Detalhe;
using System;

namespace ISync.Entidades.Movimentacao.Detalhe.Tributacao.Federal
{
    public class II : Base
    {
        /// <summary>
        /// Relacionamento Produto principal
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     P02 - Valor BC do Imposto de Importação
        /// </summary>
        public decimal VBC { get; private set; }

        /// <summary>
        ///     P03 - Valor despesas aduaneiras
        /// </summary>
        public decimal VDespAdu { get; private set; }

        /// <summary>
        ///     P04 - Valor Imposto de Importação
        /// </summary>
        public decimal VII { get; private set; }

        /// <summary>
        ///     P05 - Valor Imposto sobre Operações Financeiras
        /// </summary>
        public decimal VIOF { get; private set; }

        public virtual Prod Prod { get; private set; }


        protected II() { }

        public II(int id, int prodId, decimal vBC, decimal vDespAdu, decimal vII, decimal vIOF)
        {
            Id = id;
            ProdId = prodId;
            VBC = vBC;
            VDespAdu = vDespAdu;
            VII = vII;
            VIOF = vIOF;
        }
    }
}