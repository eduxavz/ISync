using System.ComponentModel;
using System.Xml.Serialization;

namespace ISync.Entidades.Movimentacao.Total
{
    /// <summary>
    ///     Código do Regime Especial de Tributação
    ///     <para>1 - Microempresa Municipal;</para>
    ///     <para>2 - Estimativa;</para>
    ///     <para>3 - Sociedade de Profissionais;</para>
    ///     <para>4 - Cooperativa;</para>
    ///     <para>5 - Microempresário Individual (MEI);</para>
    ///     <para>6 - Microempresário e Empresa de Pequeno Porte (ME/EPP)</para>
    /// </summary>
    public enum RegTribISSQN
    {
        /// <summary>
        /// 1 - Microempresa Municipal
        /// </summary>
        [Description("Microempresa Municipal")]
        TISSMicroempresaMunicipal = 1,

        /// <summary>
        /// 2 - Estimativa
        /// </summary>
        [Description("Estimativa")]
        RTISSEstimativa = 2,

        /// <summary>
        /// 3 - Sociedade de Profissionais
        /// </summary>
        [Description("Sociedade de Profissionais")]
        RTISSSociedadeProfissionais = 3,

        /// <summary>
        /// 4 - Cooperativa
        /// </summary>
        [Description("Cooperativa")]
        RTISSCooperativa = 4,

        /// <summary>
        /// 5 - Microempresário Individual (MEI)
        /// </summary>
        [Description("Microempresário Individual (MEI)")]
        RTISSMEI = 5,

        /// <summary>
        /// 6 - Microempresário e Empresa de Pequeno Porte (ME/EPP)
        /// </summary>
        [Description("Microempresário e Empresa de Pequeno Porte (ME/EPP)")]
        RTISSMEEPP = 6
    }
}