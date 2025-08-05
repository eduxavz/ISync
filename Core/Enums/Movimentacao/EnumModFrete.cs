using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ISync.Core.Enums.Movimentacao
{
    /// <summary>
    ///     Modalidade do frete
    ///     <para>0 - Contratação do Frete por conta do Remetente (CIF);</para>
    ///     <para>1 - Contratação do Frete por conta do Destinatário(FOB);</para>
    ///     <para>2 - Contratação do Frete por conta de Terceiros;</para>
    ///     <para>3 - Transporte Próprio por conta do Remetente;</para>
    ///     <para>4 - Transporte Próprio por conta do Destinatário;</para>
    ///     <para>9 - Sem Ocorrência de Transporte.</para>
    /// </summary>
    public enum EnumModFrete
    {
        /// <summary>
        /// 0 - Contratação do Frete por conta do Remetente (CIF)
        /// </summary>
        [Description("Contratação do Frete por conta do Remetente (CIF)")]
        [Display(Name = "Contratação do Frete por conta do Remetente (CIF)")]
        [XmlEnum("0")]
        ContaEmitenteOumfContaRemetente = 0,

        /// <summary>
        /// 1 - Contratação do Frete por conta do Destinatário(FOB)
        /// </summary>
        [Description("Contratação do Frete por conta do Destinatário(FOB)")]
        [Display(Name = "Contratação do Frete por conta do Destinatário(FOB)")]
        [XmlEnum("1")]
        ContaDestinatario = 1,

        /// <summary>
        /// 2 - Contratação do Frete por conta de Terceiros
        /// </summary>
        [Description("Contratação do Frete por conta de Terceiros")]
        [Display(Name = "Contratação do Frete por conta de Terceiros")]
        [XmlEnum("2")]
        ContaTerceiros = 2,

        /// <summary>
        /// 3 - Transporte Próprio por conta do Remetente
        /// </summary>
        [Description("Transporte Próprio por conta do Remetente")]
        [Display(Name = "Transporte Próprio por conta do Remetente")]
        [XmlEnum("3")]
        ProprioContaRemente = 3,

        /// <summary>
        /// 4 - Transporte Próprio por conta do Destinatário
        /// </summary>
        [Description("Transporte Próprio por conta do Destinatário")]
        [Display(Name = "Transporte Próprio por conta do Destinatário")]
        [XmlEnum("4")]
        ProprioContaDestinatario = 4,

        /// <summary>
        /// 9 - Sem Ocorrência de Transporte
        /// </summary>
        [Description("Sem Ocorrência de Transporte")]
        [Display(Name = "Sem Ocorrência de Transporte")]
        [XmlEnum("9")]
        SemFrete = 9
    }
}