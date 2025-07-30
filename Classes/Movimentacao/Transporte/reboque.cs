
using ISync.Classes.Core.Utils;

namespace ISync.Classes.Movimentacao.Movimentacao.Transporte
{
    public class Reboque : Base
    {
        /// <summary>
        /// Relacionamento Transporta
        /// </summary>
        public int TranspId { get; private set; }

        /// <summary>
        ///     X23 - Placa do Veículo
        /// </summary>
        public string Placa { get; private set; }

        /// <summary>
        ///     X24 - Sigla da UF
        /// </summary>
        public string UF { get; private set; }

        /// <summary>
        ///     X25 - Registro Nacional de Transportador de Carga (ANTT)
        /// </summary>
        public string RNTC { get; private set; }

        /// <summary>
        ///     X25a - Identificação do vagão
        /// </summary>
        public string Vagao { get; private set; }

        /// <summary>
        ///     X25b - Identificação da balsa
        /// </summary>
        public string Balsa { get; private set; }


        public virtual Transp Transp { get; private set; }

        protected Reboque() { }

        public Reboque(int id, int transpId, string placa, string uF, string rNTC)
        {
            Id = id;
            TranspId = transpId;
            Placa = placa.InfotechToStringSafe().ToUpper();
            UF = uF.InfotechToStringSafe().ToUpper();
            RNTC = rNTC.InfotechToStringSafe().ToUpper();
        }

        public void Atualizar(string placa, string uF, string rNTC)
        {
            Placa = placa.InfotechToStringSafe().ToUpper();
            UF = uF.InfotechToStringSafe().ToUpper();
            RNTC = rNTC.InfotechToStringSafe().ToUpper();
        }
    }
}