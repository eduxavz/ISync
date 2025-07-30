using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumTpControle
    {
        [Display(Name = "Numeração sistema")]
        NumeracaoSistema,

        [Display(Name = "Numeração banco")]
        NumeracaoBanco,

        [Display(Name = "Documento origem")]
        DocumentoOrigem,
    }
}
