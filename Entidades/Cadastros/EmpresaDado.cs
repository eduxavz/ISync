using ISync.Classes;
using System.Xml.Serialization;

namespace ISync.Entidades.Cadastros
{
    public class EmpresaDado : Base
    {
        public required string Doc { get; set; }
        public string? Ie { get; set; }
        public string? XNome { get; set; }
        public required string Fant { get; set; }
        public string? Cep { get; set; }
        public required string XLgr { get; set; }
        public required string Nro { get; set; }
        public string? XCpl { get; set; }
        public required string XBairro { get; set; }
        public int CMun { get; set; }
        public required string XMun { get; set; }
        public required string Uf { get; set; }
        public required string Fone { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public int Crt { get; set; }
    }
}
