using System.Text.Json.Serialization;

namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe.ProdEspecifico
{
    public class Encerrante : Base
    {
        /// <summary>
        /// Relacionamento Comb
        /// </summary>
        public int CombId { get; private set; }

        /// <summary>
        /// LA12 - Número de identificação do bico utilizado no abastecimento
        /// </summary>
        public int NBico { get; private set; }

        /// <summary>
        /// LA13 - Número de identificação da bomba ao qual o bico está interligado
        /// </summary>
        public int? NBomba { get; private set; }

        /// <summary>
        /// LA14 - Número de identificação do tanque ao qual o bico está interligado
        /// </summary>
        public int NTanque { get; private set; }

        /// <summary>
        /// LA15 - Valor do Encerrante no início do abastecimento
        /// </summary>
        public decimal VEncIni { get; private set; }

        /// <summary>
        /// LA16 - Valor do Encerrante no final do abastecimento
        /// </summary>
        public decimal VEncFin { get; private set; }


        [JsonIgnore]
        public virtual Comb Comb { get; private set; }


        protected Encerrante() { }

        public Encerrante(int id, int combId, int nBico, int? nBomba, int nTanque, decimal vEncIni, decimal vEncFin)
        {
            Id = id;
            CombId = combId;
            NBico = nBico;
            NBomba = nBomba;
            NTanque = nTanque;
            VEncIni = vEncIni;
            VEncFin = vEncFin;
        }
    }
}