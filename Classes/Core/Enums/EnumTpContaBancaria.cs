using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumTpContaBancaria
    {
        [Display(Name = "Poupança")]
        ContaPoupanca,
        [Display(Name = "Conta corrente")]
        ContaCorrente,
        [Display(Name = "Caixinha")]
        Caixinha,
        [Display(Name = "Investimento")]
        ContaInvestimento
    }
}
