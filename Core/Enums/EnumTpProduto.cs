using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums
{
    public enum EnumTpProduto
    {
        [Display(Name = "Mercadoria para Revenda")]
        MercadoriaRevenda = 0,

        [Display(Name = "Matéria-prima")]
        MateriaPrima = 1,

        [Display(Name = "Embalagem")]
        Embalagem = 2,

        [Display(Name = "Produto em processo")]
        ProdutoEmProcesso = 3,

        [Display(Name = "Produto acabado")]
        ProdutoAcabado = 4,

        [Display(Name = "Subproduto")]
        SubProduto = 5,

        [Display(Name = "Produto intermediário")]
        ProdutoIntermediario = 6,

        [Display(Name = "Material de uso e consumo")]
        MaterialUsoConsumo = 7,

        [Display(Name = "Ativo imobilizado")]
        AtivoImobilizado = 8,

        [Display(Name = "Serviços")]
        Servicos = 9,

        [Display(Name = "Outros insumos")]
        OutrosInsumos = 10,

        [Display(Name = "Outras")]
        Outras = 99
    }
}
