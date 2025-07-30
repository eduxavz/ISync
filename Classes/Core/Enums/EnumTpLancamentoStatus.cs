using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumTpLancamentoStatus
    {
        [Display(Name = "Em aberto")]
        Aberto,

        [Display(Name = "Parcialmente pago")]
        Parcial,

        [Display(Name = "Pago")]
        Pago,
    }
}
