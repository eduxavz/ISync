using System;
using ISync.Entidades.Movimentacao.Pagamento;

namespace ISync.Entidades.Movimentacao.Cobranca
{
    public class Dup : Base
    {
        /// <summary>
        ///     Relacionamento da Fatura 
        /// </summary>
        public int FatId { get; private set; }

        /// <summary>
        ///     Relacionamento com o detalhe do pagamento 
        /// </summary>
        public int? DetPagId { get; private set; }

        /// <summary>
        ///     Y08 - Número da Duplicata
        /// </summary>
        public string NDup { get; private set; }

        /// <summary>
        ///     Y09 - Data de vencimento
        /// </summary>
        public DateTime? DVenc { get; private set; }

        /// <summary>
        ///     Y10 - Valor da duplicata
        /// </summary>
        public decimal VDup { get; private set; }


        public virtual Fat Fat { get; private set; }

        public virtual DetPag DetPag { get; private set; }

        protected Dup() { }

        public Dup(int id, int fatId, int detPagId, string nDup, DateTime? dVenc, decimal vDup)
        {
            Id = id;
            FatId = fatId;
            DetPagId = detPagId;
            NDup = nDup;
            DVenc = dVenc;
            VDup = vDup;
        }
    }
}