using System;
namespace ISync.Entidades.Movimentacao.Transporte
{
    public class Lacre : Base
    {
        /// <summary>
        /// Relacionamento dos Volumes
        /// </summary>
        public int VolId { get; private set; }

        /// <summary>
        ///     X34 - Número dos Lacres
        /// </summary>
        public string NLacre { get; private set; }


        public virtual Vol Vol { get; private set; }

        protected Lacre() { }
        public Lacre(int id, int volId, string nLacre)
        {
            Id = id;
            VolId = volId;
            NLacre = nLacre;
        }
    }
}