using ISync.Entidades.Movimentacao.Identificacao;
using System;

namespace ISync.Entidades.Movimentacao.Intermediador
{
    public class InfIntermed : Base
    {
        public int IdeId { get; private set; }
        /// <summary>
        ///     YB02 - CNPJ do Intermediador da Transação (agenciador, plataforma de delivery, marketplace e similar) de serviços e de negócios.
        /// </summary>
        public string CNPJ { get; private set; }

        /// <summary>
        ///     YB03 - Identificador cadastrado no intermediador
        /// </summary>
        public string IdCadIntTran { get; private set; }


        public virtual Ide Ide { get; private set; }


        protected InfIntermed() { }

        public InfIntermed(int id, int ideId, string cNPJ, string idCadIntTran)
        {
            Id = id;
            IdeId = ideId;
            CNPJ = cNPJ;
            IdCadIntTran = idCadIntTran;
        }
    }
}
