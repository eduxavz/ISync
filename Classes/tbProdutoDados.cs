using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ISync.Classes
{
    [XmlType("row", Namespace = "ProdutoDados")]
    public class tbProdutoDados : Base
    {
        public int ImpostoId { get; set; }
        public int Ncm { get; set; }
        public string Origem { get; set; }
        public string DescProduto { get; set; }
        public string DescMedida { get; set; }
        public decimal VProd { get; set; }
        public string InfAdic { get; set; }
        public string CProdANP { get; set; }
        public string DescANP { get; set; }
        public decimal PGLP { get; set; }
        public decimal PGNn { get; set; }
        public decimal PGNi { get; set; }
        public string CODIF { get; set; }
        public int IndStatus { get; set; }
    }
}
