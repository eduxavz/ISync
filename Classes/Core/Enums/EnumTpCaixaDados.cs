
using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumTpCaixaDados
    {
        [Display(Name = "WebPDV")]
        WebPdv = 0,

        [Display(Name = "InfotechPdv")]
        InfotechPdv = 0,

        [Display(Name = "Saurus PDV")]
        SaurusPdv = 1,

        [Display(Name = "Saurus Mobile")]
        SaurusMobile = 3,

        [Display(Name = "Outros")]
        MercadoPago = 2
    }
}
