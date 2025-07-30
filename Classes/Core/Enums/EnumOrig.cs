using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Classes.Core.Enums
{
    public enum EnumOrigemMercadoria
    {
        /// <summary>
        /// 0-Nacional exceto as indicadas nos códigos 3, 4, 5 e 8
        /// </summary>
        [Description("Nacional exceto as indicadas nos códigos 3, 4, 5 e 8")]
        [Display(Name = "Nacional exceto as indicadas nos códigos 3, 4, 5 e 8")]
        OmNacional = 0,

        /// <summary>
        /// 1-Estrangeira - Importação direta
        /// </summary>
        [Description("Estrangeira - Importação direta")]
        [Display(Name = "Estrangeira - Importação direta")]
        OmEstrangeiraImportacaoDireta = 1,

        /// <summary>
        /// 2-Estrangeira - Adquirida no mercado interno
        /// </summary>
        [Description("Estrangeira - Adquirida no mercado interno")]
        [Display(Name = "Estrangeira - Adquirida no mercado interno")]
        OmEstrangeiraAdquiridaBrasil = 2,

        /// <summary>
        /// 3-Nacional, conteudo superior 40% e inferior ou igual a 70%
        /// </summary>
        [Description("Nacional, conteudo superior 40% e inferior ou igual a 70%")]
        [Display(Name = "Nacional, conteudo superior 40% e inferior ou igual a 70%")]
        OmNacionalConteudoImportacaoSuperior40 = 3,

        /// <summary>
        /// 4-Nacional, processos produtivos básicos
        /// </summary>
        [Description("Nacional, processos produtivos básicos")]
        [Display(Name = "Nacional, processos produtivos básicos")]
        OmNacionalProcessosBasicos = 4,

        /// <summary>
        /// 5-Nacional, conteudo inferior 40%
        /// </summary>
        [Description("Nacional, conteudo inferior 40%")]
        [Display(Name = "Nacional, conteudo inferior 40%")]
        OmNacionalConteudoImportacaoInferiorIgual40 = 5,

        /// <summary>
        /// 6-Estrangeira - Importação direta, com similar nacional, lista CAMEX
        /// </summary>
        [Description("Estrangeira - Importação direta, com similar nacional, lista CAMEX")]
        [Display(Name = "Estrangeira - Importação direta, com similar nacional, lista CAMEX")]
        OmEstrangeiraImportacaoDiretaSemSimilar = 6,

        /// <summary>
        /// 7-Estrangeira - mercado interno, sem simular,lista CAMEX
        /// </summary>
        [Description("Estrangeira - mercado interno, sem simular,lista CAMEX")]
        [Display(Name = "Estrangeira - mercado interno, sem simular,lista CAMEX")]
        OmEstrangeiraAdquiridaBrasilSemSimilar = 7,

        /// <summary>
        /// 8-Nacional, Conteúdo de Importação superior a 70%
        /// </summary>
        [Description("Nacional, Conteúdo de Importação superior a 70%")]
        [Display(Name = "Nacional, Conteúdo de Importação superior a 70%")]
        OmNacionalConteudoImportacaoSuperior70 = 8
    }
}
