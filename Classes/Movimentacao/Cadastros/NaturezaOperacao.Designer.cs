namespace ISync.Forms.Cadastros
{
    partial class NaturezaOperacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFinalidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCalculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInfAdc = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(12, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(368, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Finalidade";
            // 
            // cbFinalidade
            // 
            this.cbFinalidade.FormattingEnabled = true;
            this.cbFinalidade.Items.AddRange(new object[] {
            "Saída",
            "Entrada"});
            this.cbFinalidade.Location = new System.Drawing.Point(12, 123);
            this.cbFinalidade.Name = "cbFinalidade";
            this.cbFinalidade.Size = new System.Drawing.Size(121, 21);
            this.cbFinalidade.TabIndex = 5;
            this.cbFinalidade.Text = "Saída";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aplicar cálculos automaticamente?";
            // 
            // cbCalculo
            // 
            this.cbCalculo.FormattingEnabled = true;
            this.cbCalculo.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbCalculo.Location = new System.Drawing.Point(148, 123);
            this.cbCalculo.Name = "cbCalculo";
            this.cbCalculo.Size = new System.Drawing.Size(121, 21);
            this.cbCalculo.TabIndex = 7;
            this.cbCalculo.Text = "Sim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Informações Adicionais";
            // 
            // txtInfAdc
            // 
            this.txtInfAdc.Location = new System.Drawing.Point(15, 185);
            this.txtInfAdc.Multiline = true;
            this.txtInfAdc.Name = "txtInfAdc";
            this.txtInfAdc.Size = new System.Drawing.Size(773, 144);
            this.txtInfAdc.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(713, 335);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(632, 335);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // NaturezaOperacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtInfAdc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCalculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFinalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Name = "NaturezaOperacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Natureza de Operação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFinalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCalculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInfAdc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
    }
}