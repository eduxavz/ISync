using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumIndEscala
    {
        /// <summary>
        /// S -  Produzido em Escala Relevante
        /// </summary>
        [Description("Produzido em Escala Relevante")]
        [Display(Name = "Produzido em Escala Relevante")]
        S = 'S',

        /// <summary>
        /// N – Produzido em Escala NÃO Relevante
        /// </summary>
        [Description("Produzido em Escala NÃO Relevante")]
        [Display(Name = "Produzido em Escala NÃO Relevante")]
        N = 'N'
    }
}
