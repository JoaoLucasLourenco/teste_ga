using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste_ga.Misc;
using teste_ga.Models;

namespace teste_ga
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        
        private decimal somaImposto = 0.0m;

        private void LoadData()
        {
            dataVisualizacao.DataSource = null;
            dataVisualizacao.DataSource = Globals.listaFuncionarios;
        }

        private Funcionario GetFuncionario()
        {
            Funcionario func = Globals.listaFuncionarios.FirstOrDefault(f => f.Id == Globals.idEmEdicao);
            return func;
        }

        private void SetFuncionario()
        {
            Funcionario func = GetFuncionario();
            txtNomeCompleto.Text = func.Nome;
            maskedTxtCPF.Text = func.CPF;
            txtCargo.Text = func.Cargo;
            txtDataNascimento.Text = func.DataNascimento.ToString();
            lblDadosFuncionario.Text = $"Id: {Globals.idEmEdicao}";
            txtSalario.Enabled = btnCalcularImposto.Enabled = true;
        }

        private void ClearFields()
        {
            lblImposto.Text = txtSalario.Text = txtNomeCompleto.Text = 
            maskedTxtCPF.Text = txtCargo.Text = txtDataNascimento.Text = "";
            lblDadosFuncionario.Text = "Selecione um funcionário";
            btnSalvarCalculo.Enabled = txtSalario.Enabled = 
                btnCalcularImposto.Enabled = lblImposto.Visible = btnCalcularImposto.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

            if(Globals.idEmEdicao != null)
            {
                SetFuncionario();
            }
            else
            {
                ClearFields();
            }
                
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            

            if (dataVisualizacao.CurrentRow.Index != -1)
            {
                
                if(dataVisualizacao.CurrentRow.Cells["Id"].Value != null)
                {
                    Globals.idEmEdicao = dataVisualizacao.CurrentRow.Cells["Id"].Value.ToString();
                    SetFuncionario();
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário selecionado", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;

            if ((e.KeyChar == ',' || e.KeyChar == '.') &&
                ((sender as TextBox).Text.Contains(",") == false && (sender as TextBox).Text.Contains(".") == false))
            {
                if (e.KeyChar == '.')
                    e.KeyChar = ',';

                return;
            }

            e.Handled = true;
        }

        private void btnCRUDFuncionario_Click(object sender, EventArgs e)
        {
            Form form = new Form1();

            form.Show();

            this.Hide();
        }

        private void btnCalcularImposto_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text.Equals("") || txtSalario.Text.Equals(null))
            {
                MessageBox.Show("Informe um salário!", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
            {
                decimal salario = Convert.ToDecimal(txtSalario.Text);
                decimal imposto = 0.0m;

                btnSalvarCalculo.Enabled = true;

                if (salario <= Globals.IR_Limites[0])
                {
                    lblImposto.Text = $"Imposto Calculado \nSalário: {salario:C2}" +
                        $"\nSalário igual ou menor que {Globals.IR_Limites[0]:C2}\n Funcionário Isento de imposto!";
                }
                else
                {

                    decimal baseCalculo = 0.0m;
                    lblImposto.Text = $"Imposto Calculado\n Salário: {salario:C2}";
                    if (salario > Globals.IR_Limites[0])
                    {
                        baseCalculo = Math.Min(salario, Globals.IR_Limites[1]) - Globals.IR_Limites[0];
                        imposto = baseCalculo * Globals.IR_Porcentagens[0];
                        lblImposto.Text +=
                           $"\nImposto na faixa 1: {Globals.IR_Porcentagens[0]*100}% sobre {baseCalculo} = {imposto:C2}";
                        somaImposto += imposto;
                    }

                    if (salario > Globals.IR_Limites[1])
                    {
                        baseCalculo = Math.Min(salario, Globals.IR_Limites[2]) - Globals.IR_Limites[1];
                        imposto = baseCalculo * Globals.IR_Porcentagens[1];
                        lblImposto.Text +=
                           $"\nImposto na faixa 2: {Globals.IR_Porcentagens[1] * 100}% sobre {baseCalculo} = {imposto:C2}";
                        somaImposto += imposto;
                    }

                    if (salario > Globals.IR_Limites[2])
                    {
                        baseCalculo = salario - Globals.IR_Limites[2];
                        imposto = baseCalculo * Globals.IR_Porcentagens[2];
                        lblImposto.Text +=
                           $"\nImposto na faixa 3: {Globals.IR_Porcentagens[2] * 100}% sobre {baseCalculo} = {imposto:C2}";
                        somaImposto += imposto;
                    }
                    
                    
                    lblImposto.Text += $"\nImposto total devido: {somaImposto:C2}";
                }
                    
                    
                lblImposto.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void btnSalvarCalculo_Click(object sender, EventArgs e)
        {
            if (txtSalario.Text.Equals("") || txtSalario.Text.Equals(null))
            {
                MessageBox.Show("Informe um salário!", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            else
            {
                ImpostoFuncionario impostoFuncionario = new ImpostoFuncionario();
                impostoFuncionario.NomeFuncionario = GetFuncionario().Nome;
                impostoFuncionario.CargoFuncionario = GetFuncionario().Cargo;
                impostoFuncionario.DataCalculo = DateTime.Now;
                impostoFuncionario.Id = Guid.NewGuid().ToString();
                impostoFuncionario.Salario = txtSalario.Text;
                impostoFuncionario.Imposto = somaImposto.ToString();

                Globals.listaImpostoFuncionario.Add(impostoFuncionario);

                ClearFields();

                MessageBox.Show("Cálculo salvo com sucesso!", "Sucesso",
                        MessageBoxButtons.OK);
            }
                
        }
    }
}
