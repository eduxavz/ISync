using System;

namespace ISync.Classes.Movimentacao.Movimentacao.Identificacao
{
    public class NFref : Base
    {
        public int IdeId { get; private set; }

        /// <summary>
        ///     BA02 - Chave de acesso da NF-e referenciada
        /// </summary>
        public string RefNFe { get; private set; }

        /// <summary>
        ///     BA21 - Modelo do Documento Fiscal
        /// </summary>
        public string Mod { get; private set; }

        /// <summary>
        ///     BA22 - Número de ordem sequencial do ECF
        /// </summary>
        public int NECF { get; private set; }

        /// <summary>
        ///     BA23 - Número do Contador de Ordem de Operação - COO
        /// </summary>
        public int NCOO { get; private set; }

        /// <summary>
        ///     BA04 - Código da UF do emitente
        /// </summary>
        public int CUF { get; private set; }

        /// <summary>
        ///     BA05 - Ano e Mês de emissão da NF-e
        /// </summary>
        public string AAMM { get; private set; }

        /// <summary>
        ///     BA06 - CNPJ do emitente
        /// </summary>
        public string CNPJ { get; private set; }

        /// <summary>
        ///     BA08 - Série do Documento Fiscal
        /// </summary>
        public int Serie { get; private set; }

        /// <summary>
        ///     BA09 - Número do Documento Fiscal
        /// </summary>
        public int NNF { get; private set; }

        /// <summary>
        ///     BA15 - IE do emitente
        /// </summary>
        public string IE { get; private set; }

        public virtual Ide Ide { get; private set; }

        protected NFref() { }

        public NFref(int id, int ideId, string refNFe, string mod, int nECF, int nCOO, int cUF, string aAMM, string cNPJ, int serie, int nNF, string iE)
        {
            Id = id;
            IdeId = ideId;
            RefNFe = refNFe;
            Mod = mod;
            NECF = nECF;
            NCOO = nCOO;
            CUF = cUF;
            AAMM = aAMM;
            CNPJ = cNPJ;
            Serie = serie;
            NNF = nNF;
            IE = iE;
        }
    }
}