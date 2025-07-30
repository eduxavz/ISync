using ISync.Classes.Movimentacao.Movimentacao.Identificacao;
using System;
using System.Collections.Generic;

namespace ISync.Classes.Movimentacao.Movimentacao.Cobranca
{
    public class Fat : Base
    {
        /// <summary>
        /// Relacionamento Ide
        /// </summary>
        public Guid IdeId { get; private set; }

        /// <summary>
        ///     Y03 - Número da Fatura
        /// </summary>
        public string NFat { get; private set; }

        /// <summary>
        ///     Y04 - Valor Original da Fatura
        /// </summary>
        public decimal? VOrig { get; private set; }

        /// <summary>
        ///     Y05 - Valor do desconto
        /// </summary>
        public decimal? VDesc { get; private set; }

        /// <summary>
        ///     Y06 - Valor Líquido da Fatura
        /// </summary>
        public decimal? VLiq { get; private set; }

        public virtual Ide Ide { get; private set; }
        public virtual ICollection<Dup> Dups { get; private set; }
        public virtual ICollection<FatPagProd> PagProds { get; private set; }

        protected Fat() { }

        public Fat(int id, Guid ideId, string nFat, decimal? vOrig, decimal? vDesc, decimal? vLiq)
        {
            Id = id;
            IdeId = ideId;
            NFat = nFat;
            VOrig = vOrig;
            VDesc = vDesc;
            VLiq = vLiq;

            PagProds = new List<FatPagProd>();
        }

        public void AdicionarDup(Dup dup)
        {
            Dups = new List<Dup>();
            Dups.Add(dup);
        }

        public void AdicionarPagProd(FatPagProd pagProd)
        {
            if (pagProd != null)
            {
                PagProds = new List<FatPagProd>();
                PagProds.Add(pagProd);
            }
        }

        public void AdicionarPagProds(List<FatPagProd> pagProds)
        {
            PagProds = pagProds;
        }

        public void AtualizarValores(decimal vOrig)
        {
            VOrig = vOrig;

            //if (vDesc is not null) VDesc = vDesc;
            //if (vAcresc is not null) VOutro = vAcresc;
        }
    }
}