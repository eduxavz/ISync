using System;

namespace ISync.Classes.Movimentacao.Movimentacao.Transporte
{
    public class VeicTransp : Base
    {
        /// <summary>
        /// Relacionamento Transp
        /// </summary>
        public int TranspId { get; private set; }

        /// <summary>
        ///     X19 - Placa do Veículo
        /// </summary>
        public string Placa { get; private set; }

        /// <summary>
        ///     X20 - Sigla da UF
        /// </summary>
        public string UF { get; private set; }

        /// <summary>
        ///     X21 - Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        public string RNTC { get; private set; }


        //EF Relacionamento
        public virtual Transporta Transporta { get; private set; }


        protected VeicTransp() { }

        public VeicTransp(int id, int transpId, string placa, string uF, string rNTC)
        {
            Id = id;
            TranspId = transpId;
            Placa = placa;
            UF = uF;
            RNTC = rNTC;
        }
    }
}