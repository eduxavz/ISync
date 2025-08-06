using DFe.Classes.Flags;
using ISync.Classes.Configuracao;
using NFe.Classes;
using NFe.Classes.Informacoes;
using NFe.Classes.Informacoes.Cobranca;
using NFe.Classes.Informacoes.Destinatario;
using NFe.Classes.Informacoes.Detalhe;
using NFe.Classes.Informacoes.Detalhe.Tributacao;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Informacoes.Observacoes;
using NFe.Classes.Informacoes.Pagamento;
using NFe.Classes.Informacoes.Total;
using NFe.Classes.Informacoes.Transporte;
using NFe.Utils;
using NFe.Utils.InformacoesSuplementares;
using NFe.Utils.NFe;
using NFe.Utils.Tributacao.Estadual;
using NFe.Utils.Tributacao.Federal;
using System.Reflection;

namespace ISync.Servicos.NotaFiscal
{

    public class NFeService
    {
        private const string ArquivoConfiguracao = @"\configuracao.xml";
        private const string TituloErro = "Erro";
        private ConfiguracaoApp _configuracoes;
        private NFe.Classes.NFe _nfe;
        private readonly string? _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        /// <summary>
        /// Obter NFe Validada
        /// </summary>
        /// <param name="versaoServico">Versão do Serviço</param>
        /// <param name="modelo">Modelo do pagamento</param>
        /// <param name="numero"> Número da Nota Fiscal</param>
        /// <returns></returns>
        public NFe.Classes.NFe ObterNfeValidada(VersaoServico versaoServico, ModeloDocumento modelo, int numero)
        {
            var nfe = GetNf(numero, modelo, versaoServico);

            nfe.Assina();

            if (nfe.infNFe.ide.mod == ModeloDocumento.NFCe)
            {
                nfe.infNFeSupl = new infNFeSupl();
                if (versaoServico == VersaoServico.Versao400)
                {
                    //nfe.infNFeSupl.urlChave = nfe.infNFeSupl.ObterUrlConsulta(nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode);
                    //nfe.infNFeSupl.qrCode = nfe.infNFeSupl.ObterUrlQrCode(nfe, _configuracoes.ConfiguracaoDanfeNfce.VersaoQrCode, configuracaoCsc.CIdToken, configuracaoCsc.Csc, _configuracoes.CfgServico.Certificado);
                }
            }

            nfe.Valida();

            return nfe;
        }

        #region Criar NFe

        protected virtual NFe.Classes.NFe GetNf(int numero, ModeloDocumento modelo, VersaoServico versao)
        {
            var nf = new NFe.Classes.NFe { infNFe = GetInf(numero, modelo, versao) };
            return nf;
        }

        protected virtual infNFe GetInf(int numero, ModeloDocumento modelo, VersaoServico versao)
        {
            var infNFe = new infNFe
            {
                versao = versao.VersaoServicoParaString(),
                ide = GetIdentificacao(numero, modelo, versao),
                emit = GetEmitente(),
                dest = GetDestinatario(versao, modelo),
                transp = GetTransporte()
            };

            for (var i = 0; i < 5; i++)
            {
                infNFe.det.Add(GetDetalhe(i, infNFe.emit.CRT, modelo));
            }

            infNFe.total = GetTotal(versao, infNFe.det);

            if (infNFe.ide.mod == ModeloDocumento.NFe & (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400))
                infNFe.cobr = GetCobranca(infNFe.total.ICMSTot); //V3.00 e 4.00 Somente
            if (infNFe.ide.mod == ModeloDocumento.NFCe || (infNFe.ide.mod == ModeloDocumento.NFe & versao == VersaoServico.Versao400))
                infNFe.pag = GetPagamento(infNFe.total.ICMSTot, versao); //NFCe Somente  

            if (infNFe.ide.mod == ModeloDocumento.NFCe & versao != VersaoServico.Versao400)
                infNFe.infAdic = new infAdic() { infCpl = "Troco: 10,00" }; //Susgestão para impressão do troco em NFCe

            return infNFe;
        }

        protected virtual ide GetIdentificacao(int numero, ModeloDocumento modelo, VersaoServico versao)
        {
            var ide = new ide
            {
                cUF = _configuracoes.EnderecoEmitente.UF,
                natOp = "VENDA",
                mod = modelo,
                serie = 1,
                nNF = numero,
                tpNF = TipoNFe.tnSaida,
                cMunFG = _configuracoes.EnderecoEmitente.cMun,
                tpEmis = _configuracoes.CfgServico.tpEmis,
                tpImp = TipoImpressao.tiRetrato,
                cNF = "1234",
                tpAmb = _configuracoes.CfgServico.tpAmb,
                finNFe = FinalidadeNFe.fnNormal,
                verProc = "4.000",
                indIntermed = IndicadorIntermediador.iiSemIntermediador
            };

            if (ide.tpEmis != TipoEmissao.teNormal)
            {
                ide.dhCont = DateTime.Now;
                ide.xJust = "TESTE DE CONTIGÊNCIA PARA NFe/NFCe";
            }

            #region V2.00

            if (versao == VersaoServico.Versao200)
            {
                ide.dEmi = DateTime.Today; //Mude aqui para enviar a nfe vinculada ao EPEC, V2.00
                ide.dSaiEnt = DateTime.Today;
            }

            #endregion

            #region V3.00

            if (versao == VersaoServico.Versao200) return ide;

            if (versao == VersaoServico.Versao310)
            {
                ide.indPag = IndicadorPagamento.ipVista;
            }


            ide.idDest = DestinoOperacao.doInterna;
            ide.dhEmi = DateTime.Now;
            //Mude aqui para enviar a nfe vinculada ao EPEC, V3.10
            if (ide.mod == ModeloDocumento.NFe)
                ide.dhSaiEnt = DateTime.Now;
            else
                ide.tpImp = TipoImpressao.tiNFCe;
            ide.procEmi = ProcessoEmissao.peAplicativoContribuinte;
            ide.indFinal = ConsumidorFinal.cfConsumidorFinal; //NFCe: Tem que ser consumidor Final
            ide.indPres = PresencaComprador.pcPresencial; //NFCe: deve ser 1 ou 4

            #endregion

            return ide;
        }

        protected virtual emit GetEmitente()
        {
            var emit = _configuracoes.Emitente; // new emit
            //{
            //    //CPF = "12345678912",
            //    CNPJ = "12345678000189",
            //    xNome = "RAZAO SOCIAL LTDA",
            //    xFant = "FANTASIA LTRA",
            //    IE = "123456789",
            //};
            emit.enderEmit = GetEnderecoEmitente();
            return emit;
        }

        protected virtual enderEmit GetEnderecoEmitente()
        {
            var enderEmit = _configuracoes.EnderecoEmitente; // new enderEmit
            //{
            //    xLgr = "RUA TESTE DE ENREREÇO",
            //    nro = "123",
            //    xCpl = "1 ANDAR",
            //    xBairro = "CENTRO",
            //    cMun = 2802908,
            //    xMun = "ITABAIANA",
            //    UF = "SE",
            //    CEP = 49500000,
            //    fone = 79123456789
            //};
            enderEmit.cPais = 1058;
            enderEmit.xPais = "BRASIL";
            return enderEmit;
        }

        protected virtual dest GetDestinatario(VersaoServico versao, ModeloDocumento modelo)
        {
            var dest = new dest(versao)
            {
                CNPJ = "99999999000191",
                //CPF = "99999999999",
            };
            dest.xNome = "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL"; //Obrigatório para NFe e opcional para NFCe
            dest.enderDest = GetEnderecoDestinatario(); //Obrigatório para NFe e opcional para NFCe

            //if (versao == VersaoServico.Versao200)
            //    dest.IE = "ISENTO";
            if (versao == VersaoServico.Versao200) return dest;

            dest.indIEDest = indIEDest.NaoContribuinte; //NFCe: Tem que ser não contribuinte V3.00 Somente
            dest.email = "teste@gmail.com"; //V3.00 Somente
            return dest;
        }

        protected virtual enderDest GetEnderecoDestinatario()
        {
            var enderDest = new enderDest
            {
                xLgr = "RUA ...",
                nro = "S/N",
                xBairro = "CENTRO",
                cMun = 2802908,
                xMun = "ITABAIANA",
                UF = "SE",
                CEP = "49500000",
                cPais = 1058,
                xPais = "BRASIL"
            };
            return enderDest;
        }

        protected virtual det GetDetalhe(int i, CRT crt, ModeloDocumento modelo)
        {
            var det = new det
            {
                nItem = i + 1,
                prod = GetProduto(i + 1),
                imposto = new imposto
                {
                    vTotTrib = 0.17m,

                    ICMS = new ICMS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do ICMS
                        //TipoICMS = ObterIcmsBasico(crt),

                        //Caso você resolva utilizar método ObterIcmsBasico(), comente esta proxima linha
                        TipoICMS =
                            crt == CRT.SimplesNacional || crt == CRT.SimplesNacionalMei
                                ? InformarCSOSN(Csosnicms.Csosn102)
                                : InformarICMS(Csticms.Cst00, VersaoServico.Versao310)
                    },

                    //ICMSUFDest = new ICMSUFDest()
                    //{
                    //    pFCPUFDest = 0,
                    //    pICMSInter = 12,
                    //    pICMSInterPart = 0,
                    //    pICMSUFDest = 0,
                    //    vBCUFDest = 0,
                    //    vFCPUFDest = 0,
                    //    vICMSUFDest = 0,
                    //    vICMSUFRemet = 0
                    //},

                    COFINS = new COFINS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do COFINS
                        //TipoCOFINS = ObterCofinsBasico(),

                        //Caso você resolva utilizar método ObterCofinsBasico(), comente esta proxima linha
                        TipoCOFINS = new COFINSOutr { CST = CSTCOFINS.cofins99, pCOFINS = 0, vBC = 0, vCOFINS = 0 }
                    },

                    PIS = new PIS
                    {
                        //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do PIS
                        //TipoPIS = ObterPisBasico(),

                        //Caso você resolva utilizar método ObterPisBasico(), comente esta proxima linha
                        TipoPIS = new PISOutr { CST = CSTPIS.pis99, pPIS = 0, vBC = 0, vPIS = 0 }
                    }
                }
            };

            if (modelo == ModeloDocumento.NFe) //NFCe não aceita grupo "IPI"
            {
                det.imposto.IPI = new IPI()
                {
                    cEnq = 999,

                    //Se você já tem os dados de toda a tributação persistida no banco em uma única tabela, utilize a linha comentada abaixo para preencher as tags do IPI
                    //TipoIPI = ObterIPIBasico(),

                    //Caso você resolva utilizar método ObterIPIBasico(), comente esta proxima linha
                    TipoIPI = new IPITrib() { CST = CSTIPI.ipi00, pIPI = 5, vBC = 1, vIPI = 0.05m }
                };
            }

            //det.impostoDevol = new impostoDevol() { IPI = new IPIDevolvido() { vIPIDevol = 10 }, pDevol = 100 };

            return det;
        }

        protected virtual prod GetProduto(int i)
        {
            var p = new prod
            {
                cProd = i.ToString().PadLeft(5, '0'),
                cEAN = "7770000000012",
                xProd = i == 1 ? "NOTA FISCAL EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL" : "ABRACADEIRA NYLON 6.6 BRANCA 91X92 " + i,
                NCM = "84159090",
                CFOP = 5102,
                uCom = "UNID",
                qCom = 1,
                vUnCom = 1.1m,
                vProd = 1.1m,
                vDesc = 0.10m,
                cEANTrib = "7770000000012",
                uTrib = "UNID",
                qTrib = 1,
                vUnTrib = 1.1m,
                indTot = IndicadorTotal.ValorDoItemCompoeTotalNF,
                //NVE = {"AA0001", "AB0002", "AC0002"},
                //CEST = ?

                //ProdutoEspecifico = new arma
                //{
                //    tpArma = TipoArma.UsoPermitido,
                //    nSerie = "123456",
                //    nCano = "123456",
                //    descr = "TESTE DE ARMA"
                //}
            };
            return p;
        }

        protected virtual ICMSBasico InformarICMS(Csticms CST, VersaoServico versao)
        {
            var icms20 = new ICMS20
            {
                orig = OrigemMercadoria.OmNacional,
                CST = Csticms.Cst20,
                modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                vBC = 1.1m,
                pICMS = 18,
                vICMS = 0.20m,
                motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
            };
            if (versao == VersaoServico.Versao310)
                icms20.vICMSDeson = 0.10m; //V3.00 ou maior Somente

            switch (CST)
            {
                case Csticms.Cst00:
                    return new ICMS00
                    {
                        CST = Csticms.Cst00,
                        modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                        orig = OrigemMercadoria.OmNacional,
                        pICMS = 18,
                        vBC = 1.1m,
                        vICMS = 0.20m
                    };
                case Csticms.Cst20:
                    return icms20;
                case Csticms.Cst02:
                    break;
                case Csticms.Cst10:
                    break;
                case Csticms.Cst15:
                    break;
                case Csticms.CstPart10:
                    break;
                case Csticms.Cst30:
                    break;
                case Csticms.Cst40:
                    break;
                case Csticms.Cst41:
                    break;
                case Csticms.CstRep41:
                    break;
                case Csticms.Cst50:
                    break;
                case Csticms.Cst51:
                    break;
                case Csticms.Cst53:
                    break;
                case Csticms.Cst60:
                    break;
                case Csticms.CstRep60:
                    break;
                case Csticms.Cst61:
                    break;
                case Csticms.Cst70:
                    break;
                case Csticms.Cst90:
                    break;
                case Csticms.CstPart90:
                    break;
            }

            return new ICMS10();
        }

        protected virtual ICMSBasico ObterIcmsBasico(CRT crt)
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto ICMSGeral, como no exemplo abaixo.
            var icmsGeral = new ICMSGeral
            {
                orig = OrigemMercadoria.OmNacional,
                CST = Csticms.Cst00,
                modBC = DeterminacaoBaseIcms.DbiValorOperacao,
                vBC = 1.1m,
                pICMS = 18,
                vICMS = 0.20m,
                motDesICMS = MotivoDesoneracaoIcms.MdiTaxi
            };
            return icmsGeral.ObterICMSBasico(crt);
        }

        private PISBasico ObterPisBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto PISGeral, como no exemplo abaixo.
            var pisGeral = new PISGeral()
            {
                CST = CSTPIS.pis01,
                vBC = 1.1m,
                pPIS = 1.65m,
                vPIS = 0.01m,
                vAliqProd = 0
            };

            return pisGeral.ObterPISBasico();
        }

        private COFINSBasico ObterCofinsBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto COFINSGeral, como no exemplo abaixo.
            var cofinsGeral = new COFINSGeral()
            {
                CST = CSTCOFINS.cofins01,
                vBC = 1.1m,
                pCOFINS = 1.65m,
                vCOFINS = 0.01m,
                vAliqProd = 0
            };

            return cofinsGeral.ObterCOFINSBasico();
        }

        private IPIBasico ObterIPIBasico()
        {
            //Leia os dados de seu banco de dados e em seguida alimente o objeto IPIGeral, como no exemplo abaixo.
            var ipiGeral = new IPIGeral()
            {
                CST = CSTIPI.ipi01,
                vBC = 1.1m,
                pIPI = 5m,
                vIPI = 0.05m
            };

            return ipiGeral.ObterIPIBasico();
        }

        protected virtual ICMSBasico InformarCSOSN(Csosnicms CST)
        {
            switch (CST)
            {
                case Csosnicms.Csosn101:
                    return new ICMSSN101
                    {
                        CSOSN = Csosnicms.Csosn101,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn102:
                    return new ICMSSN102
                    {
                        CSOSN = Csosnicms.Csosn102,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn201:
                    return new ICMSSN201
                    {
                        CSOSN = Csosnicms.Csosn201,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn202:
                    return new ICMSSN202
                    {
                        CSOSN = Csosnicms.Csosn202,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn203:
                    return new ICMSSN102
                    {
                        CSOSN = Csosnicms.Csosn202,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn300:
                    return new ICMSSN202
                    {
                        CSOSN = Csosnicms.Csosn202,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn400:
                    return new ICMSSN202
                    {
                        CSOSN = Csosnicms.Csosn202,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn500:
                    return new ICMSSN500
                    {
                        CSOSN = Csosnicms.Csosn500,
                        orig = OrigemMercadoria.OmNacional
                    };
                case Csosnicms.Csosn900:
                    return new ICMSSN900
                    {
                        CSOSN = Csosnicms.Csosn900,
                        orig = OrigemMercadoria.OmNacional
                    };
                default:
                    return new ICMSSN102();
            }
        }

        protected virtual total GetTotal(VersaoServico versao, List<det> produtos)
        {
            var icmsTot = new ICMSTot
            {
                vProd = produtos.Sum(p => p.prod.vProd),
                vDesc = produtos.Sum(p => p.prod.vDesc ?? 0),
                vTotTrib = produtos.Sum(p => p.imposto.vTotTrib ?? 0),
            };

            if (versao == VersaoServico.Versao310 || versao == VersaoServico.Versao400)
                icmsTot.vICMSDeson = 0;

            if (versao == VersaoServico.Versao400)
            {
                icmsTot.vFCPUFDest = 0;
                icmsTot.vICMSUFDest = 0;
                icmsTot.vICMSUFRemet = 0;
                icmsTot.vFCP = 0;
                icmsTot.vFCPST = 0;
                icmsTot.vFCPSTRet = 0;
                icmsTot.vIPIDevol = 0;
            }

            foreach (var produto in produtos)
            {
                if (produto.imposto.IPI != null && produto.imposto.IPI.TipoIPI.GetType() == typeof(IPITrib))
                    icmsTot.vIPI = icmsTot.vIPI + ((IPITrib)produto.imposto.IPI.TipoIPI).vIPI ?? 0;
                if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS00))
                {
                    icmsTot.vBC = icmsTot.vBC + ((ICMS00)produto.imposto.ICMS.TipoICMS).vBC;
                    icmsTot.vICMS = icmsTot.vICMS + ((ICMS00)produto.imposto.ICMS.TipoICMS).vICMS;
                }
                if (produto.imposto.ICMS.TipoICMS.GetType() == typeof(ICMS20))
                {
                    icmsTot.vBC = icmsTot.vBC + ((ICMS20)produto.imposto.ICMS.TipoICMS).vBC;
                    icmsTot.vICMS = icmsTot.vICMS + ((ICMS20)produto.imposto.ICMS.TipoICMS).vICMS;
                }
                //Outros Ifs aqui, caso vá usar as classes ICMS00, ICMS10 para totalizar
            }

            //** Regra de validação W16-10 que rege sobre o Total da NF **//
            icmsTot.vNF =
                icmsTot.vProd
                - icmsTot.vDesc
                - icmsTot.vICMSDeson.GetValueOrDefault()
                + icmsTot.vST
                + icmsTot.vFCPST.GetValueOrDefault()
                + icmsTot.vFrete
                + icmsTot.vSeg
                + icmsTot.vOutro
                + icmsTot.vII
                + icmsTot.vIPI
                + icmsTot.vIPIDevol.GetValueOrDefault();

            var t = new total { ICMSTot = icmsTot };
            return t;
        }

        protected virtual transp GetTransporte()
        {
            //var volumes = new List<vol> {GetVolume(), GetVolume()};

            var t = new transp
            {
                modFrete = ModalidadeFrete.mfSemFrete //NFCe: Não pode ter frete
                //vol = volumes 
            };

            return t;
        }

        protected virtual vol GetVolume()
        {
            var v = new vol
            {
                esp = "teste de espécie",
                lacres = [new lacres { nLacre = "123456" }]
            };

            return v;
        }

        protected virtual cobr GetCobranca(ICMSTot icmsTot)
        {
            var valorParcela = (icmsTot.vNF / 2).Arredondar(2);
            var c = new cobr
            {
                fat = new fat { nFat = "12345678910", vLiq = icmsTot.vNF, vOrig = icmsTot.vNF, vDesc = 0m },
                dup =
                [
                    new() {nDup = "001", dVenc = DateTime.Now.AddDays(30), vDup = valorParcela},
                    new() {nDup = "002", dVenc = DateTime.Now.AddDays(60), vDup = icmsTot.vNF - valorParcela}
                ]
            };

            return c;
        }

        protected virtual List<pag> GetPagamento(ICMSTot icmsTot, VersaoServico versao)
        {
            var valorPagto = (icmsTot.vNF / 2).Arredondar(2);

            if (versao != VersaoServico.Versao400) // difernte de versão 4 retorna isso
            {
                var p = new List<pag>
                {
                    new() {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto},
                    new() {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}
                };
                return p;
            }


            // igual a versão 4 retorna isso
            var p4 = new List<pag>
            {
                //new pag {detPag = new detPag {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto}},
                //new pag {detPag = new detPag {tPag = FormaPagamento.fpCheque, vPag = icmsTot.vNF - valorPagto}}
                new ()
                {
                    detPag =
                    [
                        new() {tPag = FormaPagamento.fpDinheiro, vPag = valorPagto},

                    ]
                }
            };


            return p4;
        }

        #endregion


    }
}

