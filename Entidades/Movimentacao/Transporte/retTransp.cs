using ISync.Classes;
using System;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Transporte
{
    public class RetTransp : Base
    {
        /// <summary>
        /// Relacionamento Transp
        /// </summary>
        public int TranspId { get; private set; }

        /// <summary>
        ///     X12 - Valor do Serviço
        /// </summary>
        public decimal VServ { get; private set; }

        /// <summary>
        ///     X13 - BC da Retenção do ICMS
        /// </summary>
        public decimal VBCRet { get; private set; }

        /// <summary>
        ///     X14 - Alíquota da Retenção
        /// </summary>
        public decimal PICMSRet { get; private set; }

        /// <summary>
        ///     X15 - Valor do ICMS Retido
        /// </summary>
        public decimal VICMSRet { get; private set; }

        /// <summary>
        ///     X16 - CFOP
        /// </summary>
        public int CFOP { get; private set; }

        /// <summary>
        ///     X17 - Código do município de ocorrência do fato gerador do ICMS do transporte
        /// </summary>
        public long CMunFG { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Transp Transp { get; set; }

        protected RetTransp() { }

        public RetTransp(int id, int transpId, decimal vServ, decimal vBCRet, decimal pICMSRet, decimal vICMSRet, int cFOP, long cMunFG)
        {
            Id = id;
            TranspId = transpId;
            VServ = vServ;
            VBCRet = vBCRet;
            PICMSRet = pICMSRet;
            VICMSRet = vICMSRet;
            CFOP = cFOP;
            CMunFG = cMunFG;
        }
    }
}