
namespace ISync.Classes.Movimentacao.Movimentacao.Cobranca
{
    public class FatPagProd : Base
    {

        /// <summary>
        ///     ID da Fatura
        /// </summary>
        public int FatId { get; private set; }

        /// <summary>
        ///     ID do Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     Y05 - Valor do desconto
        /// </summary>
        public decimal? VDesc { get; private set; }

        /// <summary>
        ///     Y06 - Valor do acréscimo
        /// </summary>
        public decimal? VAcresc { get; private set; }

        protected FatPagProd() { }

        public FatPagProd(int id, int fatId, int prodId, decimal? vDesc, decimal? vAcresc)
        {
            Id = id;
            FatId = fatId;
            ProdId = prodId;
            VDesc = vDesc;
            VAcresc = vAcresc;
        }

        public void AtualizarDesconto(decimal vDesc)
        {
            VDesc = vDesc;
        }

        public void AtualizarAcrescimo(decimal vAcresc)
        {
            VAcresc = vAcresc;
        }
    }
}