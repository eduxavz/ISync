using ISync.Classes.Core.Enums;
using ISync.Classes.Core.Utils;
using ISync.Classes.Movimentacao.Movimentacao.Identificacao;
using System.Text.Json.Serialization;

namespace ISync.Classes.Movimentacao.Movimentacao.Emitente
{
    public class Emit : Base
    {
        /// <summary>
        /// Relacionamento Identificacao
        /// </summary>
        public int IdeId { get; private set; }

        /// <summary>
        /// Relaciomento Empresa 
        /// </summary>
        public int EmpresaId { get; private set; }

        /// <summary>
        ///     C02 - Documento do emitente
        /// </summary>
        public string Doc { get; private set; }

        /// <summary>
        ///     C03 - Razão Social ou Nome do emitente
        /// </summary>
        public string XNome { get; private set; }

        /// <summary>
        ///     C04 - Nome fantasia
        /// </summary>
        public string XFant { get; private set; }

        /// <summary>
        ///     C06 - Logradouro
        /// </summary>
        public string XLgr { get; private set; }

        /// <summary>
        ///     C07 - Número
        /// </summary>
        public string Nro { get; private set; }

        /// <summary>
        ///     C08 - Complemento
        /// </summary>
        public string XCpl { get; private set; }

        /// <summary>
        ///     C09 - Bairro
        /// </summary>
        public string XBairro { get; private set; }

        /// <summary>
        ///     C10 - Código do município
        ///     <para>Código do município (utilizar a tabela do IBGE), informar 9999999 para operações com o exterior.</para>
        /// </summary>
        public long CMun { get; private set; }

        /// <summary>
        ///     C11 - Nome do município, informar EXTERIOR para operações com o exterior.
        /// </summary>
        public string XMun { get; private set; }

        /// <summary>
        ///     C12 - Sigla da UF, informar EX para operações com o exterior.
        /// </summary>
        public string UF { get; private set; }

        /// <summary>
        ///     C13 - Código do CEP
        ///     <para>Informar os zeros não significativos. (NT 2011/004)</para>
        /// </summary>
        public string CEP { get; private set; }

        /// <summary>
        ///     C14 - Código do País
        ///     <para>1058 - Brasil</para>
        /// </summary>
        public int? CPais { get; private set; }

        /// <summary>
        ///     C15 - Nome do País
        ///     <para>Brasil ou BRASIL</para>
        /// </summary>
        public string XPais { get; private set; }

        /// <summary>
        ///     C16 - Telefone
        ///     <para>
        ///         Preencher com o Código DDD + número do telefone. Nas operações com exterior é permitido informar o código do
        ///         país + código da localidade + número do telefone (v.2.0)
        ///     </para>
        /// </summary>
        public long? Fone { get; private set; }


        /// <summary>
        ///     C17 - Inscrição Estadual
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
        ///     C18 - IE do Substituto Tributário
        ///     <para>Informar a IE do ST da UF de destino da mercadoria, quando houver a retenção do ICMS ST para a UF de destino.</para>
        /// </summary>
        public string IEST { get; private set; }

        /// <summary>
        ///     C19 - Inscrição Municipal
        ///     <para>
        ///         Este campo deve ser informado, quando ocorrer a emissão de NF-e conjugada, com prestação de serviços sujeitos
        ///         ao ISSQN e fornecimento de peças sujeitos ao ICMS.
        ///     </para>
        /// </summary>
        public string IM { get; private set; }

        /// <summary>
        ///     C20 - CNAE fiscal
        ///     <para>Este campo deve ser informado quando o campo IM (C19) for informado.</para>
        /// </summary>
        public string CNAE { get; private set; }

        /// <summary>
        ///     C21 - Código de Regime Tributário
        /// </summary>
        public EnumRegime CRT { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Ide Ide { get; private set; }


        protected Emit() { }

        public Emit(int id, int ideId, int empresaId, string doc, string xNome, string xFant, string xLgr, string nro, string xCpl, string xBairro, long cMun, string xMun, string uF, string cEP, int? cPais, string xPais, long? fone, string iE, string iEST, string iM, string cNAE, EnumRegime cRT)
        {
            Id = id;
            IdeId = ideId;
            EmpresaId = empresaId;
            Doc = doc;
            XNome = xNome;
            XFant = xFant;
            XLgr = xLgr;
            Nro = nro;
            XCpl = xCpl;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF.InfotechToStringSafe().ToUpper();
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            Fone = fone;
            IE = iE;
            IEST = iEST;
            IM = iM;
            CNAE = cNAE;

            switch (cRT)
            {
                case EnumRegime.SimplesNacional:
                    CRT = cRT;
                    break;
                case EnumRegime.SimplesNacionalExcessoSublimite:
                    CRT = cRT;
                    break;
                case EnumRegime.RegimeNormalReal:
                case EnumRegime.RegimeNormalPresumido:
                    CRT = EnumRegime.RegimeNormalPresumido;
                    break;
                default:
                    CRT = cRT;
                    break;
            }
        }

        public void Atualizar(string doc, string xNome, string xFant, string xLgr, string nro, string xCpl, string xBairro, long cMun, string xMun, string uF, string cEP, int? cPais, string xPais, long? fone, string iE, string iEST, string iM, string cNAE, EnumRegime cRT)
        {
            Doc = doc;
            XNome = xNome;
            XFant = xFant;
            XLgr = xLgr;
            Nro = nro;
            XCpl = xCpl;
            XBairro = xBairro;
            CMun = cMun;
            XMun = xMun;
            UF = uF.InfotechToStringSafe().ToUpper();
            CEP = cEP;
            CPais = cPais;
            XPais = xPais;
            Fone = fone;
            IE = iE;
            IEST = iEST;
            IM = iM;
            CNAE = cNAE;

            switch (cRT)
            {
                case EnumRegime.SimplesNacional:
                    CRT = cRT;
                    break;
                case EnumRegime.SimplesNacionalExcessoSublimite:
                    CRT = cRT;
                    break;
                case EnumRegime.RegimeNormalReal:
                case EnumRegime.RegimeNormalPresumido:
                    CRT = EnumRegime.RegimeNormalPresumido;
                    break;
                default:
                    CRT = cRT;
                    break;
            }
        }

        public bool NecessitaResponsavelTecnico()
        {
            switch (UF)
            {
                case "AM":
                case "MS":
                case "PE":
                case "PR":
                case "SC":
                case "TO":
                    return true;
                default:
                    return false;
            }
        }
    }
}