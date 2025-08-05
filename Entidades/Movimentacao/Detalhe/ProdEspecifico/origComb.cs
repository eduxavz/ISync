using ISync.Classes;
using ISync.Classes.Utils;
using ISync.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISync.Entidades.Movimentacao.Detalhe.ProdEspecifico
{
    public class OrigComb 
    {
        private decimal _pOrig;

        /// <summary>
        /// LA19 - Indicador de importação
        /// </summary>
        public int indImport { get; set; }

        /// <summary>
        /// LA20 - Código da UF
        /// </summary>
        public EnumEstado? cUFOrig { get; set; }

        /// <summary>
        /// LA21 - Percentual originário para a UF
        /// </summary>
        public decimal pOrig
        {
            get { return _pOrig.Arredondar(4); }
            set { _pOrig = value.Arredondar(4); }
        }

    }
}
