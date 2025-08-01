using ISync.Classes;
using System.Xml.Serialization;

namespace ISync.Entidades.Cadastros
{
    public class Imposto : Base
    {
        public required string DescImposto { get; set; }
        public int Cfop { get; set; }
        public string? CBenef { get; set; }
        public required string IcmsCst { get; set; }
        public int IcmsModBc { get; set; }
        public decimal IcmsPRedBc { get; set; }
        public decimal IcmsPIcms { get; set; }
        public int IcmsModBcSt { get; set; }
        public decimal IcmsPMvaVUnidSt { get; set; }
        public decimal IcmsPredBcSt { get; set; }
        public decimal IcmsPIcmsSt { get; set; }
        public int IcmsMotDesIcms { get; set; }
        public decimal IcmsPBcOp { get; set; }
        public string? IcmsUfSt { get; set; }
        public decimal IcmsPCredSn { get; set; }
        public decimal IcmsPredSn { get; set; }
        public string? PisCst { get; set; }
        public decimal PisPercVUnidPis { get; set; }
        public string? CofinsCst { get; set; }
        public decimal CofinsPercVUnidCofins { get; set; }
        public decimal EcfAliq { get; set; }
    }
}
