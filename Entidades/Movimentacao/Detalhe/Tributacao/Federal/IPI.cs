using ISync.Classes;
using ISync.Core.Enums.Movimentacao;
using ISync.Entidades.Movimentacao.Detalhe;
using System;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Detalhe.Tributacao.Federal
{
    public class IPI : Base
    {
        /// <summary>
        /// Relacionamento Produto principal
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     O02 - Classe de enquadramento do IPI para Cigarros e Bebidas
        /// Versão 3.10
        /// </summary>
        public string ClEnq { get; private set; }

        /// <summary>
        ///     O03 - CNPJ do produtor da mercadoria, quando diferente do emitente. Somente para os casos de exportação direta ou
        ///     indireta.
        /// </summary>
        public string CNPJProd { get; private set; }

        /// <summary>
        ///     O04 - Código do selo de controle IPI
        /// </summary>
        public string CSelo { get; private set; }

        /// <summary>
        ///     O05 - Quantidade de selo de controle
        /// </summary>
        public int? QSelo { get; private set; }

        /// <summary>
        ///     O06 - Código de Enquadramento Legal do IPI
        /// </summary>
        public int CEnq { get; private set; }


        /// <summary>
        ///     O09 - Código da Situação Tributária do IPI:
        /// </summary>
        public CSTIPI CST { get; private set; }

        /// <summary>
        ///     O10 - Valor da BC do IPI
        /// </summary>
        public decimal? VBC { get; private set; }

        /// <summary>
        ///     O11 - Quantidade total na unidade padrão para tributação (somente para os produtos tributados por unidade)
        /// </summary>
        public decimal? QUnid { get; private set; }

        /// <summary>
        ///     O12 - Valor por Unidade Tributável
        /// </summary>
        public decimal? VUnid { get; private set; }

        /// <summary>
        ///     O13 - Alíquota do IPI
        /// </summary>
        public decimal? PIPI { get; private set; }

        /// <summary>
        ///     O14 - Valor do IPI
        /// </summary>
        public decimal? VIPI { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Prod Prod { get; private set; }


        protected IPI() { }

        public IPI(int id, int prodId, CSTIPI cst, decimal? vBC, decimal? pIPI)
        {
            Id = id;
            ProdId = prodId;
            CST = cst;
            VBC = vBC;
            PIPI = pIPI;
            VIPI = decimal.Zero;
            CNPJProd = string.Empty;
            CSelo = string.Empty;
            ClEnq = string.Empty;



            CalcularIpi();
        }

        internal void Atualizar(decimal vBC)
        {
            VBC = vBC;
            CalcularIpi();
        }

        private void CalcularIpi()
        {
            switch (CST)
            {
                case CSTIPI.ipi00:
                case CSTIPI.ipi49:
                case CSTIPI.ipi50:
                case CSTIPI.ipi99:
                    CalcularCst00E49E50E99();
                    break;
            }
        }

        private void CalcularCst00E49E50E99()
        {
            if (PIPI.HasValue && PIPI > decimal.Zero)
            {
                VIPI = VBC / 100 * PIPI;
                return;
            }

            VIPI = decimal.Zero;
        }
    }
}