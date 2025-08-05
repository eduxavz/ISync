using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumTpArredondamento
    {
        [Display(Name = "Truncar")]
        Truncar,

        [Display(Name = "1 centavo")]
        UmCentavo,

        [Display(Name = "5 centavos")]
        CincoCentavos,

        [Display(Name = "9 centavos")]
        NoveCentavos,

        [Display(Name = "10 centavos")]
        DezCentavos,

        [Display(Name = "49/59 centavos")]
        CinquentaNoveCentavos,

        [Display(Name = "99 centavos")]
        NoventaNoveCentavos,
    }
}
