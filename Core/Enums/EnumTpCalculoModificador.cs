using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumTpCalculoModificador
    {
        [Display(Name = "Soma")]
        Soma,

        [Display(Name = "Rateia")]
        Rateia,

        [Display(Name = "Maior")]
        Maior,
    }
}
