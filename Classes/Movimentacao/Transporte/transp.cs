using ISync.Classes.Core.Enums.Movimentacao;
using ISync.Classes.Movimentacao.Movimentacao.Identificacao;
using System.Collections.Generic;
namespace ISync.Classes.Movimentacao.Movimentacao.Transporte
{
    public class Transp : Base
    {
        /// <summary>
        /// Relacionamento da Identicacao
        /// </summary>
        public int IdeId { get; private set; }

        public EnumModFrete ModFrete { get; private set; }


        public virtual Ide Ide { get; private set; }
        public virtual ICollection<Vol> Vols { get; private set; }
        public virtual ICollection<Reboque> Reboques { get; private set; }
        public virtual ICollection<RetTransp> RetTransps { get; private set; }
        public virtual ICollection<Transporta> Transportas { get; private set; }

        protected Transp() { }

        public Transp(int id, int ideId, EnumModFrete modFrete)
        {
            Id = id;
            IdeId = ideId;
            ModFrete = modFrete;
        }

        public void Atualizar(EnumModFrete modFrete)
        {
            ModFrete = modFrete;

            if (ModFrete == EnumModFrete.SemFrete)
            {
                if (Vols != null) Vols.Clear();
                if (Reboques != null) Reboques.Clear();
                if (RetTransps != null) RetTransps.Clear();
                if (Transportas != null) Transportas.Clear();
            }
        }

        public void AdicionarVol(Vol vol)
        {
            if (Vols == null) Vols = new List<Vol>();

            Vols.Add(vol);
        }

        public void AdicionarReboques(Reboque reboque)
        {
            if (Reboques == null) Reboques = new List<Reboque>();

            Reboques.Add(reboque);
        }

        public void AdicionarRetTransp(RetTransp retTransp)
        {
            if (RetTransps == null) RetTransps = new List<RetTransp>();

            RetTransps.Add(retTransp);
        }

        public void AdicionarTransportadora(Transporta transporta)
        {
            if (Transportas == null) Transportas = new List<Transporta>();

            Transportas.Add(transporta);
        }
    }
}