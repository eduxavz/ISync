using System.Xml.Serialization;

namespace ISync.Classes
{
    [XmlType("row", Namespace = "EmpresaDados")]
    public class tbEmpresaDados : Base
    {
        public string Doc { get; set; }
        public string Ie { get; set; }
        public string XNome { get; set; }
        public string Fant { get; set; }
        public string Cep { get; set; }
        public string XLgr { get; set; }
        public string Nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public int CMun { get; set; }
        public string XMun { get; set; }
        public string Uf { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Site { get; set; }
        public int Crt { get; set; }
    }
}
