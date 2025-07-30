using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ISync.Entidades.Movimentacao.Transporte
{
    public class Vol : Base
    {
        /// <summary>
        /// Relacionamento Transp 
        /// </summary>
        public int TranspId { get; private set; }

        /// <summary>
        ///     X27 - Quantidade de volumes transportados
        /// </summary>
        public int? QVol { get; private set; }

        /// <summary>
        ///     X28 - Espécie dos volumes transportados
        /// </summary>
        public string Esp { get; private set; }

        /// <summary>
        ///     X29 - Marca dos volumes transportados
        /// </summary>
        public string Marca { get; private set; }

        /// <summary>
        ///     X30 - Numeração dos volumes transportados
        /// </summary>
        public string NVol { get; private set; }

        /// <summary>
        ///     X31 - Peso Líquido (em kg)
        /// </summary>
        public decimal? PesoL { get; private set; }

        /// <summary>
        ///     X32 - Peso Bruto (em kg)
        /// </summary>
        public decimal? PesoB { get; private set; }


        //EF Relacionamento
        [JsonIgnore]
        public virtual Transp Transp { get; private set; }
        public virtual ICollection<Lacre> Lacres { get; private set; }


        protected Vol() { }

        public Vol(int id, int transpId, int? qVol, string esp, string marca, string nVol, decimal? pesoL, decimal? pesoB)
        {
            Id = id;
            TranspId = transpId;
            QVol = qVol;
            Esp = esp;
            Marca = marca;
            NVol = nVol;
            PesoL = pesoL;
            PesoB = pesoB;
        }

        public void Atualizar(int? qVol, string esp, string marca, string nVol, decimal? pesoL, decimal? pesoB)
        {
            QVol = qVol;
            Esp = esp;
            Marca = marca;
            NVol = nVol;
            PesoL = pesoL;
            PesoB = pesoB;
        }
    }
}