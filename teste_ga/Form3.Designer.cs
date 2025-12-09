namespace teste_ga
{
    partial class Form3
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
            this.dataVisualizacao = new System.Windows.Forms.DataGridView();
            this.btnCalculoImposto = new System.Windows.Forms.Button();
            this.lblImposto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDataCalculo = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCRUDFuncionario = new System.Windows.Forms.Button();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.btnDeletarCalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVisualizacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVisualizacao
            // 
            this.dataVisualizacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVisualizacao.Location = new System.Drawing.Point(538, 53);
            this.dataVisualizacao.Name = "dataVisualizacao";
            this.dataVisualizacao.RowHeadersWidth = 51;
            this.dataVisualizacao.RowTemplate.Height = 24;
            this.dataVisualizacao.Size = new System.Drawing.Size(792, 446);
            this.dataVisualizacao.TabIndex = 1;
            this.dataVisualizacao.DoubleClick += new System.EventHandler(this.dataVisualizacao_DoubleClick);
            // 
            // btnCalculoImposto
            // 
            this.btnCalculoImposto.Location = new System.Drawing.Point(277, 472);
            this.btnCalculoImposto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculoImposto.Name = "btnCalculoImposto";
            this.btnCalculoImposto.Size = new System.Drawing.Size(220, 28);
            this.btnCalculoImposto.TabIndex = 45;
            this.btnCalculoImposto.Text = "Cálculo de Imposto";
            this.btnCalculoImposto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculoImposto.UseVisualStyleBackColor = true;
            this.btnCalculoImposto.Click += new System.EventHandler(this.btnCalculoImposto_Click);
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(53, 230);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(119, 16);
            this.lblImposto.TabIndex = 44;
            this.lblImposto.Text = "Imposto Calculado";
            this.lblImposto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(56, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Limpar Seleção";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDataCalculo
            // 
            this.txtDataCalculo.Location = new System.Drawing.Point(56, 148);
            this.txtDataCalculo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataCalculo.Name = "txtDataCalculo";
            this.txtDataCalculo.ReadOnly = true;
            this.txtDataCalculo.Size = new System.Drawing.Size(158, 22);
            this.txtDataCalculo.TabIndex = 41;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(55, 194);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(315, 22);
            this.txtCargo.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Data do cálculo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(56, 99);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.ReadOnly = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(315, 22);
            this.txtNomeCompleto.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nome";
            // 
            // btnCRUDFuncionario
            // 
            this.btnCRUDFuncionario.Location = new System.Drawing.Point(55, 472);
            this.btnCRUDFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCRUDFuncionario.Name = "btnCRUDFuncionario";
            this.btnCRUDFuncionario.Size = new System.Drawing.Size(212, 28);
            this.btnCRUDFuncionario.TabIndex = 33;
            this.btnCRUDFuncionario.Text = "Cadastro de Funcionários";
            this.btnCRUDFuncionario.UseVisualStyleBackColor = true;
            this.btnCRUDFuncionario.Click += new System.EventHandler(this.btnCRUDFuncionario_Click);
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.Location = new System.Drawing.Point(53, 54);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(157, 16);
            this.lblDadosFuncionario.TabIndex = 31;
            this.lblDadosFuncionario.Text = "Selecione um funcionário";
            // 
            // btnDeletarCalculo
            // 
            this.btnDeletarCalculo.Enabled = false;
            this.btnDeletarCalculo.Location = new System.Drawing.Point(217, 421);
            this.btnDeletarCalculo.Name = "btnDeletarCalculo";
            this.btnDeletarCalculo.Size = new System.Drawing.Size(154, 23);
            this.btnDeletarCalculo.TabIndex = 46;
            this.btnDeletarCalculo.Text = "Deletar Cálculo";
            this.btnDeletarCalculo.UseVisualStyleBackColor = true;
            this.btnDeletarCalculo.Click += new System.EventHandler(this.btnDeletarCalculo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 554);
            this.Controls.Add(this.btnDeletarCalculo);
            this.Controls.Add(this.btnCalculoImposto);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDataCalculo);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCRUDFuncionario);
            this.Controls.Add(this.lblDadosFuncionario);
            this.Controls.Add(this.dataVisualizacao);
            this.Name = "Form3";
            this.Text = "Histórico de Cálculo";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisualizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVisualizacao;
        private System.Windows.Forms.Button btnCalculoImposto;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDataCalculo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCRUDFuncionario;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.Button btnDeletarCalculo;
    }
}