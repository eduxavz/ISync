namespace ISync.Forms
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            naturezaDeOperaçãoToolStripMenuItem = new ToolStripMenuItem();
            notaFiscalToolStripMenuItem = new ToolStripMenuItem();
            notaFiscalDeSaídaToolStripMenuItem = new ToolStripMenuItem();
            novaNotaFiscalToolStripMenuItem = new ToolStripMenuItem();
            consultarNotasFiscaisToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            financeiroToolStripMenuItem = new ToolStripMenuItem();
            contasÀPagarToolStripMenuItem = new ToolStripMenuItem();
            contasÀReceberToolStripMenuItem = new ToolStripMenuItem();
            pDVToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, financeiroToolStripMenuItem, notaFiscalToolStripMenuItem, configuraçõesToolStripMenuItem, pDVToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, naturezaDeOperaçãoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(191, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(191, 22);
            produtosToolStripMenuItem.Text = "Produtos";
            produtosToolStripMenuItem.Click += produtosToolStripMenuItem_Click;
            // 
            // naturezaDeOperaçãoToolStripMenuItem
            // 
            naturezaDeOperaçãoToolStripMenuItem.Name = "naturezaDeOperaçãoToolStripMenuItem";
            naturezaDeOperaçãoToolStripMenuItem.Size = new Size(191, 22);
            naturezaDeOperaçãoToolStripMenuItem.Text = "Natureza de Operação";
            naturezaDeOperaçãoToolStripMenuItem.Click += naturezaDeOperaçãoToolStripMenuItem_Click_1;
            // 
            // notaFiscalToolStripMenuItem
            // 
            notaFiscalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notaFiscalDeSaídaToolStripMenuItem });
            notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            notaFiscalToolStripMenuItem.Size = new Size(77, 20);
            notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // notaFiscalDeSaídaToolStripMenuItem
            // 
            notaFiscalDeSaídaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaNotaFiscalToolStripMenuItem, consultarNotasFiscaisToolStripMenuItem });
            notaFiscalDeSaídaToolStripMenuItem.Name = "notaFiscalDeSaídaToolStripMenuItem";
            notaFiscalDeSaídaToolStripMenuItem.Size = new Size(180, 22);
            notaFiscalDeSaídaToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // novaNotaFiscalToolStripMenuItem
            // 
            novaNotaFiscalToolStripMenuItem.Name = "novaNotaFiscalToolStripMenuItem";
            novaNotaFiscalToolStripMenuItem.Size = new Size(192, 22);
            novaNotaFiscalToolStripMenuItem.Text = "Digitar nova NF-e";
            novaNotaFiscalToolStripMenuItem.Click += novaNotaFiscalToolStripMenuItem_Click;
            // 
            // consultarNotasFiscaisToolStripMenuItem
            // 
            consultarNotasFiscaisToolStripMenuItem.Name = "consultarNotasFiscaisToolStripMenuItem";
            consultarNotasFiscaisToolStripMenuItem.Size = new Size(192, 22);
            consultarNotasFiscaisToolStripMenuItem.Text = "Consultar notas fiscais";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // financeiroToolStripMenuItem
            // 
            financeiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contasÀPagarToolStripMenuItem, contasÀReceberToolStripMenuItem });
            financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            financeiroToolStripMenuItem.Size = new Size(74, 20);
            financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasÀPagarToolStripMenuItem
            // 
            contasÀPagarToolStripMenuItem.Name = "contasÀPagarToolStripMenuItem";
            contasÀPagarToolStripMenuItem.Size = new Size(180, 22);
            contasÀPagarToolStripMenuItem.Text = "Contas à pagar";
            // 
            // contasÀReceberToolStripMenuItem
            // 
            contasÀReceberToolStripMenuItem.Name = "contasÀReceberToolStripMenuItem";
            contasÀReceberToolStripMenuItem.Size = new Size(180, 22);
            contasÀReceberToolStripMenuItem.Text = "Contas à receber";
            // 
            // pDVToolStripMenuItem
            // 
            pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            pDVToolStripMenuItem.Size = new Size(41, 20);
            pDVToolStripMenuItem.Text = "PDV";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inicio";
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalDeSaídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarNotasFiscaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturezaDeOperaçãoToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem contasÀPagarToolStripMenuItem;
        private ToolStripMenuItem contasÀReceberToolStripMenuItem;
        private ToolStripMenuItem pDVToolStripMenuItem;
    }
}