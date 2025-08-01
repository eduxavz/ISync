using ISync.Classes;

namespace ISync.Entidades.Cadastros
{
    public class NaturezaOperacao : Base
    {
        public required string DescNatureza { get; set; }
        public required string IndOperacao { get; set; }
        public required string UfOrigem { get; set; }
        public required string UfDest { get; set; }
         public required Imposto Imposto { get; set; }
        public int Calcular{ get; set; }
        public string? InfAdc { get; set; }
        public int IndStatus { get; set; }
    }
}
