using ISync.Classes;
using System;

namespace ISync.Entidades.Movimentacao.Detalhe.DeclaracaoImportacao
{
    public class Adi : Base
    {
        /// <summary>
        /// Relacionamento DI
        /// </summary>
        public int DIId { get; private set; }

        /// <summary>
        ///     I26 - Numero da Adição
        /// </summary>
        public int NAdicao { get; private set; }

        /// <summary>
        ///     I27 - Numero sequencial do item dentro da Adição
        /// </summary>
        public int NSeqAdic { get; private set; }

        /// <summary>
        ///     I28 - Código do fabricante estrangeiro
        /// </summary>
        public string CFabricante { get; private set; }

        /// <summary>
        ///     I29 - Valor do desconto do item da DI – Adição
        /// </summary>
        public decimal? VDescDI { get; private set; }

        /// <summary>
        ///     I29a - Número do ato concessório de Drawback
        /// </summary>
        public string NDraw { get; private set; }


        //EF Relacionamento
        public virtual DI DI { get; private set; }

        protected Adi() { }

        public Adi(int id, int dIId, int nAdicao, int nSeqAdic, string cFabricante, decimal? vDescDI, string nDraw)
        {
            Id = id;
            DIId = dIId;
            NAdicao = nAdicao;
            NSeqAdic = nSeqAdic;
            CFabricante = cFabricante;
            VDescDI = vDescDI;
            NDraw = nDraw;
        }


    }
}