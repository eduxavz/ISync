using System.ComponentModel;

namespace ISync.Classes.Core.Enums
{
    public enum EnumTpCaixaConfigs
    {
        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Id do Cliente Padrão (Opcional: Configuração da Empresa)")]
        Opcao9 = 9,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Versão de Revisão de Parceiros")]
        Opcao10 = 10,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Versão de Revisão de Produtos")]
        Opcao11 = 11,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Primario|Secundario")]
        [Description("Equipamento Atual")]
        Opcao14 = 14,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Manual|Automático|Semi-Automático")]
        [Description("Tipo de Recebimento de Atualizações")]
        Opcao15 = 15,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Manual|Automático|Semi-Automático")]
        [Description("Tipo de Envio de Vendas")]
        Opcao16 = 16,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("Tanca\\SAT.dll|Bematech\\BemaSAT32.dll|ControlID\\libsatid.dll|ControlID\\v2\\libsatid.dll|Daruma\\dllsat.dll|Dimep\\dllsat.dll|EpsonA10\\SAT-A10.dll|Elgin\\dllsat.dll|Elgin\\v2\\dllsat.dll|ElginLinker1\\dllsat.dll|Gertec\\GERSAT.dll|Kryptus\\SAT.dll|Nitere\\dllsat.dll|SatCare\\satcare.dll|Sweda\\SAT_Teste.dll|Urano\\SAT.DLL|Outros\\SAT.dll")]
        [Description("Nome da DLL S@T ")]
        Opcao17 = 17,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("Não|Sim")]
        [Description("Impressão de Ticket de Consumação")]
        Opcao18 = 18,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("Normal|Grade|Posto|Simples|Comandas")]
        [Description("Tipo de Visualização Tela Principal")]
        Opcao19 = 19,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Não|Sim")]
        [Description("Solicitar Cliente na Abertura da Venda")]
        Opcao20 = 20,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Não|Sim")]
        [Description("Impressão de Setor")]
        Opcao21 = 21,

        [Grupo("Configurações de TEF")]
        [TpTxt("Numero")]
        [ItemDrop("Pay&Go|TEF Dial|PayGo DLL|SiTef DLL|PagSeguro DLL|SafraPay")]
        [Description("Método de Comunicação TEF")]
        Opcao22 = 22,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Exibir Lembrete das Informações da Última Venda em Segundos")]
        Opcao23 = 23,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Não|Sim")]
        [Description("Solicitar Vendedor na Abertura da Venda")]
        Opcao24 = 24,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Fonte para Categoria")]
        Opcao25 = 25,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Fonte para Subcategoria")]
        Opcao26 = 26,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Não|Sim")]
        [Description("Desligar computador ao Sair do PDV")]
        Opcao27 = 27,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("Não|Sim")]
        [Description("Solicitar Código de Autorização do Cartão")]
        Opcao28 = 28,

        [Grupo("Configurações Gerais")]
        [TpTxt("Texto")]
        [ItemDrop("Desabilitado|20 Itens|40 Itens|80 Itens")]
        [Description("QR Code Conferência")]
        Opcao29 = 29,

        [Grupo("Configurações de Balança")]
        [TpTxt("Numero")]
        [ItemDrop("Nenhuma|Filizola|Toledo|Toledo2180|Urano|LucasTec|Magna|Digitron|Magellan|UranoPOP")]
        [Description("Modelo da Balança")]
        Opcao30 = 30,

        [Grupo("Configurações de Balança")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Porta de Comunicação")]
        Opcao31 = 31,

        [Grupo("Configurações de Balança")]
        [TpTxt("Numero")]
        [ItemDrop("1200|1800|2400|4800|7200|9600|14400|19200|38400|57600|115200|128000")]
        [Description("Velocidade da Porta")]
        Opcao32 = 32,

        [Grupo("Configurações de Balança")]
        [TpTxt("Texto")]
        [ItemDrop("One|OneAndHalf|Two")]
        [Description("Stop Bits da Porta")]
        Opcao33 = 33,

        [Grupo("Configurações de Balança")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Data Bits da Porta")]
        Opcao34 = 34,

        [Grupo("Configurações de Balança")]
        [TpTxt("Texto")]
        [ItemDrop("Even|Mark|None|Odd|Space")]
        [Description("Paridade da Porta")]
        Opcao35 = 35,

        [Grupo("Configurações de Balança")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Tamanho do Código do Produto")]
        Opcao36 = 36,

        [Grupo("Configurações de Balança")]
        [TpTxt("Texto")]
        [ItemDrop("Valor Total|Quantidade")]
        [Description("Tipo de Final de Código")]
        Opcao37 = 37,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Numero")]
        [ItemDrop("0 - Não|1 - Sim")]
        [Description("Leitor Serial Ativo")]
        Opcao40 = 40,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Porta de Comunicação")]
        Opcao41 = 41,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Numero")]
        [ItemDrop("1200|1800|2400|4800|7200|9600|14400|19200|38400|57600|115200|128000")]
        [Description("Velocidade da Porta")]
        Opcao42 = 42,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Texto")]
        [ItemDrop("One|OneAndHalf|Two")]
        [Description("Stop Bits da Porta")]
        Opcao43 = 43,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Data Bits da Porta")]
        Opcao44 = 44,

        [Grupo("Configurações de Leitor de Código de Barras")]
        [TpTxt("Texto")]
        [ItemDrop("Even|Mark|None|Odd|Space")]
        [Description("Paridade da Porta")]
        Opcao45 = 45,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Informação Complementar")]
        Opcao48 = 48,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Informação Complementar")]
        Opcao49 = 49,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("Venda Integrada|ECF|SAT CF-e|NFCe Sincrono")]
        [Description("Modelo de Venda")]
        Opcao50 = 50,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("F_Bematech|F_Daruma|F_DataRegis|F_Epson|F_FiscNet|F_ICash|F_Mecaf|F_NCR|F_Quattro|F_Schalter|F_Sweda|F_SwedaSTX|F_Urano|F_Yanco|N_CHINA_POS|N_CIS_PR1800|N_ControlID_PrintID|N_ControlID_PrintID_48|N_DASCOM_DT230|N_DIEBOLD_5970|N_Diebold_TSP143MU|N_DieboldIM453HU|N_DR700|N_DR700_CORTE|N_Elgin_i8|N_Elgin_i9|N_Elgin_VOX|N_Epson_T88IV|N_EPSON_TMT20|N_Generica|N_HTML|N_MP4000|N_MP4200|N_MP4200_V2|N_Nitere_Q3X|N_POSTECH_891|N_SWEDA_SI150|N_SWEDA_SI300|N_Tanca_PL2303|N_Tanca_TP450|N_Tanca_TP550|N_Tanca_TP650|POS_A8|POS_A9X0|POS_A930|POS_BLUETOOTH|POS_CLOUDPOS|POS_CUSTOM_FUSION|POS_ELGIN|POS_GERTEC_M55|POS_GPOS700|POS_GPOS800|POS_L400|POS_M8|POS_NEXGO|POS_POSTECH_TOTEN|POS_ROCKCHIP|POS_SHENZHEN|POS_SUNMI|POS_TXT|")]
        [Description("Modelo de Impressora")]
        Opcao51 = 51,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Porta de Comunicação")]
        Opcao52 = 52,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Numero")]
        [ItemDrop("1200|1800|2400|4800|7200|9600|14400|19200|38400|57600|115200|128000")]
        [Description("Velocidade da Porta")]
        Opcao53 = 53,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("One|OneAndHalf|Two")]
        [Description("Stop Bits da Porta")]
        Opcao54 = 54,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Data Bits da Porta")]
        Opcao55 = 55,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("Even|Mark|None|Odd|Space")]
        [Description("Paridade da Porta")]
        Opcao56 = 56,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Quantidade de Colunas")]
        Opcao57 = 57,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Texto")]
        [ItemDrop("Mini|Mini_UmaLinha|Mini_DuasLinhas|Mini_SemDet|Mini_SemCliente|Mini_SemEmitente|Mini_Orcamento")]
        [Description("Modelo de Impressão")]
        Opcao58 = 58,

        [Grupo("Equipamento de Venda")]
        [TpTxt("Numero")]
        [ItemDrop("Automático|Manual")]
        [Description("Tipo de Impressão")]
        Opcao59 = 59,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("Venda Integrada|ECF|SAT CF-e|NFCe Sincrono")]
        [Description("Modelo de Venda")]
        Opcao60 = 60,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("F_Bematech|F_Daruma|F_DataRegis|F_Epson|F_FiscNet|F_ICash|F_Mecaf|F_NCR|F_Quattro|F_Schalter|F_Sweda|F_SwedaSTX|F_Urano|F_Yanco|N_CHINA_POS|N_CIS_PR1800|N_ControlID_PrintID|N_ControlID_PrintID_48|N_DASCOM_DT230|N_DIEBOLD_5970|N_Diebold_TSP143MU|N_DieboldIM453HU|N_DR700|N_DR700_CORTE|N_Elgin_i8|N_Elgin_i9|N_Elgin_VOX|N_Epson_T88IV|N_EPSON_TMT20|N_Generica|N_HTML|N_MP4000|N_MP4200|N_MP4200_V2|N_Nitere_Q3X|N_POSTECH_891|N_SWEDA_SI150|N_SWEDA_SI300|N_Tanca_PL2303|N_Tanca_TP450|N_Tanca_TP550|N_Tanca_TP650|POS_A8|POS_A9X0|POS_A930|POS_BLUETOOTH|POS_CLOUDPOS|POS_CUSTOM_FUSION|POS_ELGIN|POS_GERTEC_M55|POS_GPOS700|POS_GPOS800|POS_L400|POS_M8|POS_NEXGO|POS_POSTECH_TOTEN|POS_ROCKCHIP|POS_SHENZHEN|POS_SUNMI|POS_TXT|")]
        [Description("Modelo de Impressora")]
        Opcao61 = 61,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Porta de Comunicação")]
        Opcao62 = 62,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Numero")]
        [ItemDrop("1200|1800|2400|4800|7200|9600|14400|19200|38400|57600|115200|128000")]
        [Description("Velocidade da Porta")]
        Opcao63 = 63,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("One|OneAndHalf|Two")]
        [Description("Stop Bits da Porta")]
        Opcao64 = 64,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Data Bits da Porta")]
        Opcao65 = 65,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("Even|Mark|None|Odd|Space")]
        [Description("Paridade da Porta")]
        Opcao66 = 66,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Quantidade de Colunas")]
        Opcao67 = 67,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Texto")]
        [ItemDrop("Mini|Mini_UmaLinha|Mini_DuasLinhas|Mini_SemDet|Mini_SemCliente|Mini_SemEmitente|Mini_Orcamento")]
        [Description("Modelo de Impressão")]
        Opcao68 = 68,

        [Grupo("Equipamento de Venda Contingência")]
        [TpTxt("Numero")]
        [ItemDrop("Automático|Manual")]
        [Description("Tipo de Impressão")]
        Opcao69 = 69,

        [Grupo("Configurações de Display")]
        [TpTxt("Texto")]
        [ItemDrop("GertecSerial|GertecTeclado|GertecTecladoT55|KeytecTeclado|SmakTeclado|Nenhum")]
        [Description("Tipo de Equipamento")]
        Opcao80 = 80,

        [Grupo("Configurações de Display")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Porta de Comunicação")]
        Opcao81 = 81,

        [Grupo("Configurações de Display")]
        [TpTxt("Numero")]
        [ItemDrop("1200|1800|2400|4800|7200|9600|14400|19200|38400|57600|115200|128000")]
        [Description("Velocidade da Porta")]
        Opcao82 = 82,

        [Grupo("Configurações de Display")]
        [TpTxt("Texto")]
        [ItemDrop("One|OneAndHalf|Two")]
        [Description("Stop Bits da Porta")]
        Opcao83 = 83,

        [Grupo("Configurações de Display")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Data Bits da Porta")]
        Opcao84 = 84,

        [Grupo("Configurações de Display")]
        [TpTxt("Texto")]
        [ItemDrop("Even|Mark|None|Odd|Space")]
        [Description("Paridade da Porta")]
        Opcao85 = 85,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("PAYGO - Ponto de Captura")]
        Opcao90 = 90,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("PAYGO - URL ou IP do Servidor + Porta")]
        Opcao91 = 91,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("SITEF - IP do Servidor")]
        Opcao92 = 92,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("SITEF - ID Loja")]
        Opcao93 = 93,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Stone - Stone Code")]
        Opcao94 = 94,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("Stone - Chave Privada Stone")]
        Opcao95 = 95,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("Nenhuma|Somente Lojista|Somente Cliente|Lojista e Cliente")]
        [Description("Imprimir Via do TEF")]
        Opcao96 = 96,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("Módulo Padrão de Vendas|Módulo específico REDE (Funções 16 e 17)")]
        [Description("SITEF - Módulo para Recebimentos")]
        Opcao97 = 97,

        [Grupo("Configurações de TEF")]
        [TpTxt("Texto")]
        [ItemDrop("")]
        [Description("CNPJ Homologação Software House")]
        Opcao98 = 98,

        [Grupo("Configurações Gerais")]
        [TpTxt("Numero")]
        [ItemDrop("")]
        [Description("Colunas para Impressão do Pré-Venda")]
        Opcao101 = 101
    }
}
