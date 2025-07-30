
namespace ISync.Classes.Movimentacao.Movimentacao.Detalhe.Exportacao
{
    public class ExportInd : Base
    {
        /// <summary>
        /// Relacionamento DetExport
        /// </summary>
        public int DetExportId { get; private set; }

        /// <summary>
        ///     I53 - Número do Registro de Exportação
        /// </summary>
        public string NRE { get; private set; }

        /// <summary>
        ///     I54 - Chave de Acesso da NF-e recebida para exportação
        /// </summary>
        public string ChNFe { get; private set; }

        /// <summary>
        ///     I55 - Quantidade do item realmente exportado
        /// </summary>
        public decimal QExport { get; private set; }


        //EF Relacionamento
        public virtual DetExport DetExport { get; private set; }

        protected ExportInd() { }

        public ExportInd(int id, int detExportId, string nRE, string chNFe, decimal qExport)
        {
            Id = id;
            DetExportId = detExportId;
            NRE = nRE;
            ChNFe = chNFe;
            QExport = qExport;
        }
    }
}