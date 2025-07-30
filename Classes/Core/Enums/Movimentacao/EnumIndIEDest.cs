using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums.Movimentacao
{
    public enum EnumIndIEDest
    {
        /// <summary>
        /// 1 – Contribuinte ICMS
        /// </summary>
        [Description("Contribuinte ICMS")]
        [Display(Name = "Contribuinte ICMS")]
        ContribuinteICMS = 1,

        /// <summary>
        /// 2 – Contribuinte isento de inscrição
        /// </summary>
        [Description("Contribuinte isento de inscrição")]
        [Display(Name = "Isento")]
        Isento = 2,

        /// <summary>
        /// 9 – Não Contribuinte
        /// </summary>
        [Description("Não Contribuinte")]
        [Display(Name = "Não Contribuinte")]
        NaoContribuinte = 9
    }
}
