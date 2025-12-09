namespace teste_ga
{
    partial class Form2
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblDadosFuncionario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCRUDFuncionario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnCalcularImposto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblImposto = new System.Windows.Forms.Label();
            this.btnHistoricoCalc = new System.Windows.Forms.Button();
            this.btnSalvarCalculo = new System.Windows.Forms.Button();
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
            this.dataVisualizacao.TabIndex = 0;
            this.dataVisualizacao.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(30, 262);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(142, 16);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário do Funcionário";
            // 
            // lblDadosFuncionario
            // 
            this.lblDadosFuncionario.AutoSize = true;
            this.lblDadosFuncionario.Location = new System.Drawing.Point(31, 53);
            this.lblDadosFuncionario.Name = "lblDadosFuncionario";
            this.lblDadosFuncionario.Size = new System.Drawing.Size(157, 16);
            this.lblDadosFuncionario.TabIndex = 2;
            this.lblDadosFuncionario.Text = "Selecione um funcionário";
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSalario.Location = new System.Drawing.Point(31, 281);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(157, 22);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // btnCRUDFuncionario
            // 
            this.btnCRUDFuncionario.Location = new System.Drawing.Point(33, 471);
            this.btnCRUDFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCRUDFuncionario.Name = "btnCRUDFuncionario";
            this.btnCRUDFuncionario.Size = new System.Drawing.Size(212, 28);
            this.btnCRUDFuncionario.TabIndex = 16;
            this.btnCRUDFuncionario.Text = "Cadastro de Funcionários";
            this.btnCRUDFuncionario.UseVisualStyleBackColor = true;
            this.btnCRUDFuncionario.Click += new System.EventHandler(this.btnCRUDFuncionario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cargo";
            // 
            // maskedTxtCPF
            // 
            this.maskedTxtCPF.Location = new System.Drawing.Point(33, 144);
            this.maskedTxtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTxtCPF.Mask = "000000000-00";
            this.maskedTxtCPF.Name = "maskedTxtCPF";
            this.maskedTxtCPF.ReadOnly = true;
            this.maskedTxtCPF.Size = new System.Drawing.Size(105, 22);
            this.maskedTxtCPF.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "CPF";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(34, 98);
            this.txtNomeCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.ReadOnly = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(315, 22);
            this.txtNomeCompleto.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(33, 236);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.ReadOnly = true;
            this.txtCargo.Size = new System.Drawing.Size(315, 22);
            this.txtCargo.TabIndex = 24;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(34, 190);
            this.txtDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.ReadOnly = true;
            this.txtDataNascimento.Size = new System.Drawing.Size(158, 22);
            this.txtDataNascimento.TabIndex = 25;
            // 
            // btnCalcularImposto
            // 
            this.btnCalcularImposto.Enabled = false;
            this.btnCalcularImposto.Location = new System.Drawing.Point(31, 329);
            this.btnCalcularImposto.Name = "btnCalcularImposto";
            this.btnCalcularImposto.Size = new System.Drawing.Size(157, 23);
            this.btnCalcularImposto.TabIndex = 26;
            this.btnCalcularImposto.Text = "Calcular Imposto";
            this.btnCalcularImposto.UseVisualStyleBackColor = true;
            this.btnCalcularImposto.Click += new System.EventHandler(this.btnCalcularImposto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(194, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(28, 368);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(119, 16);
            this.lblImposto.TabIndex = 28;
            this.lblImposto.Text = "Imposto Calculado";
            this.lblImposto.Visible = false;
            // 
            // btnHistoricoCalc
            // 
            this.btnHistoricoCalc.Location = new System.Drawing.Point(255, 471);
            this.btnHistoricoCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistoricoCalc.Name = "btnHistoricoCalc";
            this.btnHistoricoCalc.Size = new System.Drawing.Size(220, 28);
            this.btnHistoricoCalc.TabIndex = 29;
            this.btnHistoricoCalc.Text = "Histórico de Cálculos";
            this.btnHistoricoCalc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistoricoCalc.UseVisualStyleBackColor = true;
            this.btnHistoricoCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalvarCalculo
            // 
            this.btnSalvarCalculo.Enabled = false;
            this.btnSalvarCalculo.Location = new System.Drawing.Point(354, 329);
            this.btnSalvarCalculo.Name = "btnSalvarCalculo";
            this.btnSalvarCalculo.Size = new System.Drawing.Size(154, 23);
            this.btnSalvarCalculo.TabIndex = 30;
            this.btnSalvarCalculo.Text = "Salvar Cálculo";
            this.btnSalvarCalculo.UseVisualStyleBackColor = true;
            this.btnSalvarCalculo.Click += new System.EventHandler(this.btnSalvarCalculo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 554);
            this.Controls.Add(this.btnSalvarCalculo);
            this.Controls.Add(this.btnHistoricoCalc);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcularImposto);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTxtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCRUDFuncionario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblDadosFuncionario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dataVisualizacao);
            this.Name = "Form2";
            this.Text = "Cálculo Imposto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVisualizacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVisualizacao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblDadosFuncionario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCRUDFuncionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTxtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnCalcularImposto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Button btnHistoricoCalc;
        private System.Windows.Forms.Button btnSalvarCalculo;
    }
}