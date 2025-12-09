using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste_ga.Misc;
using teste_ga.Models;

namespace teste_ga
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private string IdEmVisualizacao = null;
        private void LoadData()
        {
            dataVisualizacao.DataSource = null;
            dataVisualizacao.DataSource = Globals.listaImpostoFuncionario;
        }

        private void ClearFields()
        {
            lblImposto.Text = txtNomeCompleto.Text =
            txtCargo.Text = txtDataCalculo.Text = "";
            lblDadosFuncionario.Text = "Selecione um item do histórico de cálculos";
            lblImposto.Visible = btnDeletarCalculo.Enabled = false;
            IdEmVisualizacao = null;
        }
        private ImpostoFuncionario GetImpostoFuncionario()
        {
            ImpostoFuncionario impostofunc = Globals.listaImpostoFuncionario.FirstOrDefault(f => f.Id == IdEmVisualizacao);
            return impostofunc;
        }
        private void SetCalculo()
        {
            ImpostoFuncionario impostofunc = GetImpostoFuncionario();
            txtNomeCompleto.Text = impostofunc.NomeFuncionario;
            txtCargo.Text = impostofunc.CargoFuncionario;
            txtDataCalculo.Text = impostofunc.DataCalculo.ToString();
            lblDadosFuncionario.Text = $"Id do cálculo: {IdEmVisualizacao}";
            GetCalculoDetalhado(impostofunc);
            lblImposto.Visible = btnDeletarCalculo.Enabled = true;
        }
        private void GetCalculoDetalhado(ImpostoFuncionario impostofunc)
        {
            decimal salario = Convert.ToDecimal(impostofunc.Salario);
            decimal imposto = 0.0m;
            decimal somaImposto = 0.0m;

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
                       $"\nImposto na faixa 1: {Globals.IR_Porcentagens[0] * 100}% sobre {baseCalculo} = {imposto:C2}";
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


            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
            if (IdEmVisualizacao != null)
            {
                SetCalculo();
            }
            else
            {
                ClearFields();
            }
        }

        private void btnCRUDFuncionario_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnCalculoImposto_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataVisualizacao_DoubleClick(object sender, EventArgs e)
        {
            if (dataVisualizacao.CurrentRow.Index != -1)
            {

                if (dataVisualizacao.CurrentRow.Cells["Id"].Value != null)
                {
                    IdEmVisualizacao = dataVisualizacao.CurrentRow.Cells["Id"].Value.ToString();
                    SetCalculo();
                }
                else
                {
                    MessageBox.Show("Nenhum cálculo selecionado", "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeletarCalculo_Click(object sender, EventArgs e)
        {
            if (IdEmVisualizacao == null)
            {
                MessageBox.Show("Selecione um cálculo para deletar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este cálculo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                var impostoFuncionario = GetImpostoFuncionario();

                if (impostoFuncionario != null)
                {
                    Globals.listaImpostoFuncionario.Remove(impostoFuncionario);
                    LoadData();
                    ClearFields();
                    Globals.idEmEdicao = null;

                    MessageBox.Show("Cálculo deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("A exclusão foi cancelada.");
            }
        }
    }
}
