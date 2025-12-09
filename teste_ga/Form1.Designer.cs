namespace teste_ga
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPdataNascimento = new System.Windows.Forms.DateTimePicker();
            this.maskedTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.dataVisualizacao = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmBoxCargo = new System.Windows.Forms.ComboBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.btnCalculoImposto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisualizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(43, 105);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(315, 22);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento";
            // 
            // DTPdataNascimento
            // 
            this.DTPdataNascimento.Location = new System.Drawing.Point(43, 226);
            this.DTPdataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPdataNascimento.Name = "DTPdataNascimento";
            this.DTPdataNascimento.Size = new System.Drawing.Size(315, 22);
            this.DTPdataNascimento.TabIndex = 5;
            // 
            // maskedTxtCPF
            // 
            this.maskedTxtCPF.Location = new System.Drawing.Point(43, 167);
            this.maskedTxtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTxtCPF.Mask = "000000000-00";
            this.maskedTxtCPF.Name = "maskedTxtCPF";
            this.maskedTxtCPF.Size = new System.Drawing.Size(105, 22);
            this.maskedTxtCPF.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(43, 319);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 319);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(151, 319);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(100, 28);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // dataVisualizacao
            // 
            this.dataVisualizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisualizacao.Location = new System.Drawing.Point(467, 53);
            this.dataVisualizacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataVisualizacao.Name = "dataVisualizacao";
            this.dataVisualizacao.RowHeadersWidth = 51;
            this.dataVisualizacao.Size = new System.Drawing.Size(863, 446);
            this.dataVisualizacao.TabIndex = 10;
            this.dataVisualizacao.DoubleClick += new System.EventHandler(this.dataVisualizacao_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cargo";
            // 
            // cbmBoxCargo
            // 
            this.cbmBoxCargo.FormattingEnabled = true;
            this.cbmBoxCargo.Location = new System.Drawing.Point(43, 286);
            this.cbmBoxCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmBoxCargo.Name = "cbmBoxCargo";
            this.cbmBoxCargo.Size = new System.Drawing.Size(323, 24);
            this.cbmBoxCargo.TabIndex = 12;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(39, 33);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(16, 20);
            this.idLbl.TabIndex = 14;
            this.idLbl.Text = "Id";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.idLbl.UseCompatibleTextRendering = true;
            this.idLbl.Visible = false;
            // 
            // btnCalculoImposto
            // 
            this.btnCalculoImposto.Location = new System.Drawing.Point(39, 471);
            this.btnCalculoImposto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculoImposto.Name = "btnCalculoImposto";
            this.btnCalculoImposto.Size = new System.Drawing.Size(212, 28);
            this.btnCalculoImposto.TabIndex = 15;
            this.btnCalculoImposto.Text = "Cálculo de Imposto";
            this.btnCalculoImposto.UseVisualStyleBackColor = true;
            this.btnCalculoImposto.Click += new System.EventHandler(this.btnCalculoImposto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 554);
            this.Controls.Add(this.btnCalculoImposto);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.cbmBoxCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataVisualizacao);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.maskedTxtCPF);
            this.Controls.Add(this.DTPdataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "CRUD Funcionário";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisualizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPdataNascimento;
        private System.Windows.Forms.MaskedTextBox maskedTxtCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DataGridView dataVisualizacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmBoxCargo;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button btnCalculoImposto;
    }
}

