using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumRegime
    {
        [Description("Simples Nacional")]
        [Display(Name = "Simples Nacional")]
        SimplesNacional = 1,

        [Description("Simples Nacional, excesso sublimite de receita bruta")]
        [Display(Name = "Simples Nacional, excesso sublimite de receita bruta")]
        SimplesNacionalExcessoSublimite = 2,

        [Description("Regime normal, lucro presumido")]
        [Display(Name = "Regime normal, lucro presumido")]
        RegimeNormalPresumido = 3,

        [Description("Regime normal, lucro real")]
        [Display(Name = "Regime normal, lucro real")]
        RegimeNormalReal = 4,

        [Description("MEI")]
        [Display(Name = "MEI")]
        MEI = 5,

        [Description("Não se aplica")]
        [Display(Name = "Não se aplica")]
        NaoSeAplica = 9
    }
}
