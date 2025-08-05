using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumTipoSetor
    {
        [Display(Name = "Produção")]
        Producao,

        [Display(Name = "PDV")]
        Caixa,

        [Display(Name = "Entrega")]
        Entrega,

        [Display(Name = "Boqueta")]
        Boqueta,

        [Display(Name = "Monitor")]
        Monitor,

        [Display(Name = "Boqueta Autoatendimento")]
        BoquetaATM,

        [Display(Name = "Autoatendimento Mobile")]
        ATMMobile,

        [Display(Name = "Painel de Senhas")]
        PainelSenha,

        [Display(Name = "Conferência")]
        Conferencia
    }
}
