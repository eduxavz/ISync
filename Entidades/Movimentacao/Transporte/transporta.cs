using System;
namespace ISync.Entidades.Movimentacao.Transporte
{
    public class Transporta : Base
    {
        /// <summary>
        /// Relacionamento Transp
        /// </summary>
        public int TranspId { get; private set; }

        /// <summary>
        /// Relaciomento com Cadastro Dados
        /// </summary>
        public int CadastroId { get; private set; }

        /// <summary>
        ///     X04 - CNPJ do Transportador
        /// </summary>
        public string Doc { get; private set; }

        /// <summary>
        ///     X06 - Razão Social ou nome
        /// </summary>
        public string XNome { get; private set; }

        /// <summary>
        ///     X07 - Inscrição Estadual do Transportador
        /// </summary>
        public string IE { get; private set; }

        /// <summary>
        ///     X08 - Endereço Completo
        /// </summary>
        public string XEnder { get; private set; }

        /// <summary>
        ///     X09 - Nome do município
        /// </summary>
        public string XMun { get; private set; }

        /// <summary>
        ///     X10 - Sigla da UF
        /// </summary>
        public string UF { get; private set; }


        public virtual Transp Transp { get; private set; }

        protected Transporta() { }

        public Transporta(int id, int transpId, int cadastroId, string doc, string xNome, string iE, string xEnder, string xMun, string uF)
        {
            Id = id;
            TranspId = transpId;
            CadastroId = cadastroId;
            Doc = doc;
            XNome = xNome;
            IE = iE;
            XEnder = xEnder;
            XMun = xMun;
            UF = uF;
        }

        public void Atualizar(int cadastroId, string doc, string xNome, string iE, string xEnder, string xMun, string uF)
        {
            CadastroId = cadastroId;
            Doc = doc;
            XNome = xNome;
            IE = iE;
            XEnder = xEnder;
            XMun = xMun;
            UF = uF;
        }
    }
}