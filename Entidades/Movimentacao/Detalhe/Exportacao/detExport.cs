using ISync.Entidades.Movimentacao.Detalhe;
using System.Collections.Generic;

namespace ISync.Entidades.Movimentacao.Detalhe.Exportacao
{
    public class DetExport : Base
    {
        /// <summary>
        /// Relacionamento Produto
        /// </summary>
        public int ProdId { get; private set; }

        /// <summary>
        ///     I51 - Número do ato concessório de Drawback
        /// </summary>
        public string NDraw { get; private set; }


        //EF Relacionamento
        public virtual Prod Prod { get; private set; }
        public virtual ICollection<ExportInd> ExportInds { get; private set; }

        protected DetExport() { }

        public DetExport(int id, int prodId, string nDraw)
        {
            Id = id;
            ProdId = prodId;
            NDraw = nDraw;
        }

        public void AdicionarExportInd(ExportInd exportInd)
        {
            if (ExportInds == null) ExportInds = new List<ExportInd>();

            ExportInds.Add(exportInd);
        }
    }
}