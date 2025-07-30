using ISync.Classes.Movimentacao.Movimentacao.Identificacao;

namespace ISync.Classes.Movimentacao.Movimentacao.RespTecnico
{
    public class InfRespTec : Base
    {
        public int IdeId { get; private set; }

        public string CNPJ { get; private set; }

        public string XContato { get; private set; }

        public string Email { get; private set; }

        public string Fone { get; private set; }

        public int? IdCSRT { get; private set; }

        public string HashCSRT { get; private set; }

        public virtual Ide Ide { get; private set; }

        protected InfRespTec() { }

        public InfRespTec(int id, int ideId, string cNPJ, string xContato, string email, string fone, int? idCSRT, string hashCSRT)
        {
            Id = id;
            IdeId = ideId;
            CNPJ = cNPJ;
            XContato = xContato;
            Email = email;
            Fone = fone;
            IdCSRT = idCSRT;
            HashCSRT = hashCSRT;
        }
    }
}
