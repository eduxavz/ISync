using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumTpLancamento
    {
        [Display(Name = "Despesa")]
        Despesa,

        [Display(Name = "Receita")]
        Receita,

        [Display(Name = "Transferência")]
        Transferencia,
    }
}
