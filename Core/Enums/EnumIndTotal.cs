using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumIndTotal
    {
        /// <summary>
        /// 0 – o valor do item (vProd) não compõe o valor total da NF-e (vProd)
        /// </summary>
        [Description("Valor do item não compõe o total da NF-e")]
        [Display(Name = "Valor do item não compõe o total da NF-e")]
        ValorDoItemNaoCompoeTotalNF = 0,

        /// <summary>
        /// 1  – o valor do item (vProd) compõe o valor total da NF-e (vProd)
        /// </summary>
        [Description("Valor do item compõe o total da NF-e")]
        [Display(Name = "Valor do item compõe o total da NF-e")]
        ValorDoItemCompoeTotalNF = 1
    }
}
