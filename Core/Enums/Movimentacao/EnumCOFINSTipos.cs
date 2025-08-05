using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISync.Core.Enums.Movimentacao
{
    /// <summary>
    ///     <para>01 - Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))</para>
    ///     <para>02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))</para>
    ///     <para>03 - Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))</para>
    ///     <para>04 - Operação Tributável (tributação monofásica (alíquota zero))</para>
    ///     <para>05 - Operação Tributável (Substituição Tributária)</para>
    ///     <para>06 - Operação Tributável (alíquota zero)</para>
    ///     <para>07 - Operação Isenta da Contribuição</para>
    ///     <para>08 - Operação Sem Incidência da Contribuição</para>
    ///     <para>09 - Operação com Suspensão da Contribuição</para>
    ///     <para>49 - Outras Operações de Saída</para>
    ///     <para>50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para>
    ///     <para>51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno</para>
    ///     <para>52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação</para>
    ///     <para>53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para>
    ///     <para>54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para>
    ///     <para>60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno</para>
    ///     <para>61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno</para>
    ///     <para>62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação</para>
    ///     <para>63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno</para>
    ///     <para>64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação</para>
    ///     <para>66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação</para>
    ///     <para>67 - Crédito Presumido - Outras Operações</para>
    ///     <para>70 - Operação de Aquisição sem Direito a Crédito</para>
    ///     <para>71 - Operação de Aquisição com Isenção</para>
    ///     <para>72 - Operação de Aquisição com Suspensão</para>
    ///     <para>73 - Operação de Aquisição a Alíquota Zero</para>
    ///     <para>74 - Operação de Aquisição sem Incidência da Contribuição</para>
    ///     <para>75 - Operação de Aquisição por Substituição Tributária</para>
    ///     <para>98 - Outras Operações de Entrada</para>
    ///     <para>99 - Outras Operações</para>
    /// </summary>
    public enum CSTCOFINS
    {
        /// <summary>
        /// 01 - Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))
        /// </summary>
        [Description("Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))")]
        [Display(Name = "01 - Operação Tributável (base de cálculo = valor da operação (alíquota normal (cumulativo/não cumulativo)))")]
        cofins01 = 01,

        /// <summary>
        /// 02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))
        /// </summary>
        [Description("Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))")]
        [Display(Name = "02 - Operação Tributável (base de cálculo = valor da operação (alíquota diferenciada))")]
        cofins02 = 02,

        /// <summary>
        /// 03 - Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))
        /// </summary>
        [Description("Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))")]
        [Display(Name = "03 - Operação Tributável (base de cálculo = quantidade vendida (alíquota por unidade de produto))")]
        cofins03 = 03,

        /// <summary>
        /// 04 - Operação Tributável (tributação monofásica (alíquota zero))
        /// </summary>
        [Description("Operação Tributável (tributação monofásica (alíquota zero))")]
        [Display(Name = "04 - Operação Tributável (tributação monofásica (alíquota zero))")]
        cofins04 = 04,

        /// <summary>
        /// 05 - Operação Tributável (Substituição Tributária)
        /// </summary>
        [Description("Operação Tributável (Substituição Tributária)")]
        [Display(Name = "05 - Operação Tributável (Substituição Tributária)")]
        cofins05 = 05,

        /// <summary>
        /// 06 - Operação Tributável (alíquota zero)
        /// </summary>
        [Description("Operação Tributável (alíquota zero)")]
        [Display(Name = "06 - Operação Tributável (alíquota zero)")]
        cofins06 = 06,

        /// <summary>
        /// 07 - Operação Isenta da Contribuição
        /// </summary>
        [Description("Operação Isenta da Contribuição")]
        [Display(Name = "07 - Operação Isenta da Contribuição")]
        cofins07 = 07,

        /// <summary>
        /// 08 - Operação Sem Incidência da Contribuição
        /// </summary>
        [Description("Operação Sem Incidência da Contribuição")]
        [Display(Name = "08 - Operação Sem Incidência da Contribuição")]
        cofins08 = 08,

        /// <summary>
        /// 09 - Operação com Suspensão da Contribuição
        /// </summary>
        [Description("Operação com Suspensão da Contribuição")]
        [Display(Name = "09 - Operação com Suspensão da Contribuição")]
        cofins09 = 09,

        /// <summary>
        /// 49 - Outras Operações de Saída
        /// </summary>
        [Description("Outras Operações de Saída")]
        [Display(Name = "49 - Outras Operações de Saída")]
        cofins49 = 49,

        /// <summary>
        /// 50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
        [Display(Name = "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
        cofins50 = 50,

        /// <summary>
        /// 51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno")]
        [Display(Name = "51 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno")]
        cofins51 = 51,

        /// <summary>
        /// 52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação")]
        [Display(Name = "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação")]
        cofins52 = 52,

        /// <summary>
        /// 53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
        [Display(Name = "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
        cofins53 = 53,

        /// <summary>
        /// 54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
        [Display(Name = "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
        cofins54 = 54,

        /// <summary>
        /// 55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
        [Display(Name = "55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
        cofins55 = 55,

        /// <summary>
        /// 56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação
        /// </summary>
        [Description("Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
        [Display(Name = "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
        cofins56 = 56,

        /// <summary>
        /// 60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
        [Display(Name = "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno")]
        cofins60 = 60,

        /// <summary>
        /// 61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno")]
        [Display(Name = "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno")]
        cofins61 = 61,

        /// <summary>
        /// 62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação")]
        [Display(Name = "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação")]
        cofins62 = 62,

        /// <summary>
        /// 63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
        [Display(Name = "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno")]
        cofins63 = 63,

        /// <summary>
        /// 64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
        [Display(Name = "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação")]
        cofins64 = 64,

        /// <summary>
        /// 65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
        [Display(Name = "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação")]
        cofins65 = 65,

        /// <summary>
        /// 66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação
        /// </summary>
        [Description("Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
        [Display(Name = "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação")]
        cofins66 = 66,

        /// <summary>
        /// 67 - Crédito Presumido - Outras Operações
        /// </summary>
        [Description("Crédito Presumido - Outras Operações")]
        [Display(Name = "67 - Crédito Presumido - Outras Operações")]
        cofins67 = 67,

        /// <summary>
        /// 70 - Operação de Aquisição sem Direito a Crédito
        /// </summary>
        [Description("Operação de Aquisição sem Direito a Crédito")]
        [Display(Name = "70 - Operação de Aquisição sem Direito a Crédito")]
        cofins70 = 70,

        /// <summary>
        /// 71 - Operação de Aquisição com Isenção
        /// </summary>
        [Description("Operação de Aquisição com Isenção")]
        [Display(Name = "71 - Operação de Aquisição com Isenção")]
        cofins71 = 71,

        /// <summary>
        /// 72 - Operação de Aquisição com Suspensão
        /// </summary>
        [Description("Operação de Aquisição com Suspensão")]
        [Display(Name = "72 - Operação de Aquisição com Suspensão")]
        cofins72 = 72,

        /// <summary>
        /// 73 - Operação de Aquisição a Alíquota Zero
        /// </summary>
        [Description("Operação de Aquisição a Alíquota Zero")]
        [Display(Name = "73 - Operação de Aquisição a Alíquota Zero")]
        cofins73 = 73,

        /// <summary>
        /// 74 - Operação de Aquisição sem Incidência da Contribuição
        /// </summary>
        [Description("Operação de Aquisição sem Incidência da Contribuição")]
        [Display(Name = "74 - Operação de Aquisição sem Incidência da Contribuição")]
        cofins74 = 74,

        /// <summary>
        /// 75 - Operação de Aquisição por Substituição Tributária
        /// </summary>
        [Description("Operação de Aquisição por Substituição Tributária")]
        [Display(Name = "75 - Operação de Aquisição por Substituição Tributária")]
        cofins75 = 75,

        /// <summary>
        /// 98 - Outras Operações de Entrada
        /// </summary>
        [Description("Outras Operações de Entrada")]
        [Display(Name = "98 - Outras Operações de Entrada")]
        cofins98 = 98,

        /// <summary>
        /// 99 - Outras Operações
        /// </summary>
        [Description("Outras Operações")]
        [Display(Name = "99 - Outras Operações")]
        cofins99 = 99
    }
}