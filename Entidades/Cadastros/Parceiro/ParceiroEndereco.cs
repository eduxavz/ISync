using ISync.Classes;
using ISync.Classes.Core.Enums.Movimentacao;


namespace ISync.Entidades.Cadastros.Parceiro
{
    public class ParceiroEndereco : Base
    {
        public int CadastroId { get; private set; }
        public string CEP { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Referencia { get; private set; }
        public string Bairro { get; private set; }
        public string CMun { get; private set; }
        public string XMun { get; private set; }
        public string UF { get; private set; }
        public int CUF { get; private set; }
        public string Pais { get; private set; }
        public string CPais { get; private set; }
        public EnumIndIEDest? IndIEDest { get; private set; }
        public string IERG { get; private set; }

        public virtual Parceiro Cadastro { get; set; }

        protected ParceiroEndereco()
        {

        }

        public ParceiroEndereco(int id, int cadastroId, string cep, string logradouro, string numero, string complemento, string referencia, string bairro, string cMun, string xMun, string uf, int cUf, EnumIndIEDest indIeDest, string ierg)
        {
            Id = id;
            CadastroId = cadastroId;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Referencia = referencia;
            Bairro = bairro;
            CMun = cMun;
            XMun = xMun;
            UF = uf;
            CUF = cUf;
            Pais = "BRASIL";
            CPais = "1058";
            IndIEDest = indIeDest;
            IERG = ierg;
        }

        public void Atualizar(string cep, string logradouro, string numero, string complemento, string referencia, string bairro, string cMun, string xMun, string uf, int cUf, EnumIndIEDest? indIeDest, string ierg)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Referencia = referencia;
            Bairro = bairro;
            CMun = cMun;
            XMun = xMun;
            UF = uf;
            CUF = cUf;
            IndIEDest = indIeDest;
            IERG = ierg;
        }
    }

}
