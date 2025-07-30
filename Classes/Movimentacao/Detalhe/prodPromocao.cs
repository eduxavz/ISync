
namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe
{

    public enum EnumTpPromocao
    {
        Tipo1 = 0,
        Tipo2 = 2
    }

    public class ProdPromocao : Base 
    {
        public int PromocaoId { get; set; }
        public int ProdId { get; set; }
        public string DescPromocao { get; set; }
        public EnumTpPromocao TpPromocao { get; set; }
        public decimal VDescTot { get; set; }
        public decimal? VDesc { get; set; }

        protected ProdPromocao() { }

        public ProdPromocao(int id, int promocaoId, int prodId, string descPromocao, EnumTpPromocao tpPromocao, decimal vDescTot, decimal vDesc)
        {
            Id = id;
            PromocaoId = promocaoId;
            ProdId = prodId;
            DescPromocao = descPromocao;
            TpPromocao = tpPromocao;
            VDescTot = vDescTot;
            VDesc = vDesc;
        }
    }
}