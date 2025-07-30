using ISync.Classes;
using System;
using System.Xml.Serialization;

namespace ISync.Entidades.Cadastros
{
        public class tbCadastroDados : Base
    {
            public int TpCadastro { get; set; }
            public required string Doc { get; set; }
            public required string IndIeDest { get; set; }
            public string? Ie { get; set; }
            public required string XNome { get; set; }
            public string Cep { get; set; }
            public string XLgr { get; set; }
            public string Nro { get; set; }
            public string XCpl { get; set; }
            public string XBairro { get; set; }
            public string CMun { get; set; }
            public string XMun { get; set; }
            public string Uf { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public string InfAdic { get; set; }
            public int IndStatus { get; set; }
        }
    }
