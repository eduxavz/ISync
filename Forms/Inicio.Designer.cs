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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalDeSaídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotasFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturezaDeOperaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.notaFiscalToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.naturezaDeOperaçãoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaFiscalDeSaídaToolStripMenuItem});
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // notaFiscalDeSaídaToolStripMenuItem
            // 
            this.notaFiscalDeSaídaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaNotaFiscalToolStripMenuItem,
            this.consultarNotasFiscaisToolStripMenuItem});
            this.notaFiscalDeSaídaToolStripMenuItem.Name = "notaFiscalDeSaídaToolStripMenuItem";
            this.notaFiscalDeSaídaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notaFiscalDeSaídaToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // novaNotaFiscalToolStripMenuItem
            // 
            this.novaNotaFiscalToolStripMenuItem.Name = "novaNotaFiscalToolStripMenuItem";
            this.novaNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.novaNotaFiscalToolStripMenuItem.Text = "Digitar nova NF-e";
            this.novaNotaFiscalToolStripMenuItem.Click += new System.EventHandler(this.novaNotaFiscalToolStripMenuItem_Click);
            // 
            // consultarNotasFiscaisToolStripMenuItem
            // 
            this.consultarNotasFiscaisToolStripMenuItem.Name = "consultarNotasFiscaisToolStripMenuItem";
            this.consultarNotasFiscaisToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultarNotasFiscaisToolStripMenuItem.Text = "Consultar notas fiscais";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // naturezaDeOperaçãoToolStripMenuItem
            // 
            this.naturezaDeOperaçãoToolStripMenuItem.Name = "naturezaDeOperaçãoToolStripMenuItem";
            this.naturezaDeOperaçãoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.naturezaDeOperaçãoToolStripMenuItem.Text = "Natureza de Operação";
            this.naturezaDeOperaçãoToolStripMenuItem.Click += new System.EventHandler(this.naturezaDeOperaçãoToolStripMenuItem_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}