using ISync.Classes.Core.Enums.Movimentacao;
using ISync.Entidades.Movimentacao.Identificacao;
using System;

namespace ISync.Entidades.Movimentacao.Destinatario
{
    public class Dest : Base
    {
        /// <summary>
        /// Relacionamento Identificacao
        /// </summary>
        public Guid IdeId { get; private set; }

        /// <summary>
        /// Relaciomento Cadastro Dados
        /// </summary>
        public Guid CadastroId { get; private set; }

        /// <summary>
        ///     E02 - CNPJ do destinatário
        /// </summary>
        public string Documento { get; private set; }

        /// <summary>
        ///     E03a - Identificador do destinatário, em caso de comprador estrangeiro
        /// </summary>
        public string IdEstrangeiro { get; private set; }

        /// <summary>
        ///     E04 - Razão Social ou nome do destinatário
        /// </summary>
        public string XNome { get; private set; }

        /// <summary>
        ///     E06 - Logradouro
        /// </summary>
        public string XLgr { get; private set; }

        /// <summary>
        ///     E07 - Número
        /// </summary>
        public string Nro { get; private set; }

        /// <summary>
        ///     E08 - Complemento
        /// </summary>
        public string XCpl { get; private set; }

        /// <summary>
        ///     E09 - Bairro
        /// </summary>
        public string XBairro { get; private set; }

        /// <summary>
        ///     E10 - Código do município
        ///     <para>Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior.</para>
        /// </summary>
        public long CMun { get; private set; }

        /// <summary>
        ///     E11 - Nome do município, informar EXTERIOR para operações com o exterior.
        /// </summary>
        public string XMun { get; private set; }

        /// <summary>
        ///     E12 - Sigla da UF, informar EX para operações com o exterior.
        /// </summary>
        public string UF { get; private set; }

        /// <summary>
        ///     E13 - Código do CEP
        ///     <para>Informar os zeros não significativos. (NT 2011/004)</para>
        /// </summary>
        public string CEP { get; private set; }

        /// <summary>
        ///     E14 - Código do País
        ///     <para>1058 - Brasil</para>
        /// </summary>
        public int? CPais { get; private set; }

        /// <summary>
        ///     E15 - Nome do País
        ///     <para>Brasil ou BRASIL</para>
        /// </summary>
        public string XPais { get; private set; }

        /// <summary>
        ///     E16 - Telefone
        ///     <para>
        ///         Preencher com o Código DDD + número do telefone. Nas operações com exterior é permitido informar o código do
        ///         país + código da localidade + número do telefone (v.2.0)
        ///     </para>
        /// </summary>
        public long? Fone { get; private set; }


        /// <summary>
        ///     E16a - Indicador da IE do destinatário:
        /// </summary>
        public EnumIndIEDest? IndIEDest { get; private set; } //Nulable por conta da v2.00

        /// <summary>
        ///     E17 - Inscrição Estadual
        ///     <para>Campo de informação obrigatória nos casos de emissão própria (procEmi = 0, 2 ou 3).</para>
        ///     <para>
        ///         A IE deve ser informada apenas com algarismos para destinatários contribuintes do ICMS, sem caracteres de
        ///         formatação (ponto, barra, hífen, etc.);
        ///     </para>
        ///     <para>
        ///         O literal “ISENTO” deve ser informado apenas para contribuintes do ICMS que são isentos de inscrição no
        ///         cadastro de contribuintes do ICMS e estejam emitindo NF-e avulsa;
        ///     </para>
        /// </summary>
        public string IE { get; private set; }

        /// <summary>
        ///     E18 - Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob
        ///     controle da SUFRAMA)
        /// </summary>
        public string ISUF { get; private set; }

        /// <summary>
        ///     E18a - Inscrição Municipal
        ///     <para>
        ///         Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de serviços sujeitos
        ///         ao ISSQN e fornecimento de peças sujeitos ao ICMS.
        ///     </para>
        /// </summary>
        public string IM { get; private set; }

        /// <summary>
        ///     E19 - Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail de recepção da NF-e
        ///     indicada pelo destinatário
        /// </summary>
        public string Email { get; private set; }

        public virtual Ide Ide { get; private set; }

        protected Dest() { }

        public Dest(int id, Guid ideId, Guid cadastroId, string documento, string idEstrangeiro, string xNome, string xLgr, string nro, string xCpl, string xBairro, long cMun, string xMun, string uF, string cEP, int? cPais, string xPais, long? fone, EnumIndIEDest? indIEDest, string iE, string iSUF, string iM, string email)
        {
            Id = id;
            IdeId = ideId;
            CadastroId = cadastroId;
            Documento = documento;
            IdEstrangeiro = idEstrangeiro;
            XNome = xNome;
            XLgr = xLgr;
            Nro = nro;
            XCpl = xCpl;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF;
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            Fone = fone;
            IndIEDest = indIEDest;
            IE = iE;
            ISUF = iSUF;
            IM = iM;
            Email = email;
        }

        public void Atualizar(Guid cadastroId, string documento, string idEstrangeiro, string xNome, string xLgr, string nro, string xCpl, string xBairro, long cMun, string xMun, string uF, string cEP, int? cPais, string xPais, long? fone, EnumIndIEDest? indIEDest, string iE, string iSUF, string iM, string email)
        {
            CadastroId = cadastroId;
            Documento = documento;
            IdEstrangeiro = idEstrangeiro;
            XNome = xNome;
            XLgr = xLgr;
            Nro = nro;
            XCpl = xCpl;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF;
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            Fone = fone;
            IndIEDest = indIEDest;
            IE = iE;
            ISUF = iSUF;
            IM = iM;
            Email = email;
        }
    }
}