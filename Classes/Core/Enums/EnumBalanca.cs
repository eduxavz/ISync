using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumBalanca
    {
        [Display(Name = "Não pesável")]
        Normal,

        [Display(Name = "Produto unitário")]
        Unitario,

        [Display(Name = "Produto pesado na venda")]
        PesadoVenda,

        [Display(Name = "Produto pesável")]
        Pesavel,

        [Display(Name = "Produto glaciado")]
        Glaciado
    }
}
