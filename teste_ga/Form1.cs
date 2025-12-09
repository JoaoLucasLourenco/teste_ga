using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using teste_ga.Misc;
using teste_ga.Models;
using teste_ga.Validation;

namespace teste_ga
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        


        private bool ValidName(string nome)
        {
            return Regex.IsMatch(nome, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$");
        }

        
        private void ClearFields()
        {
            txtNomeCompleto.Text = maskedTxtCPF.Text = "";
            DTPdataNascimento.Value = DateTime.Today;
            btnDeletar.Enabled = false;
            btnSalvar.Text = "Salvar";
            cbmBoxCargo.SelectedIndex = -1;
            idLbl.Visible = false;
        }

        private void LoadData()
        {
            dataVisualizacao.DataSource = null;
            dataVisualizacao.DataSource = Globals.listaFuncionarios;
        }

        private Funcionario GetFuncionario()
        {
            var func = Globals.listaFuncionarios.FirstOrDefault(f => f.Id == Globals.idEmEdicao);
            return func;
        }
        private void SetFuncionario()
        {
            var func = GetFuncionario();
            txtNomeCompleto.Text = func.Nome;
            maskedTxtCPF.Text = func.CPF;
            cbmBoxCargo.SelectedItem = func.Cargo;
            DTPdataNascimento.Value = func.DataNascimento ;
            idLbl.Text = $"Id: {Globals.idEmEdicao}";
            btnSalvar.Text = "Editar";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearFields();
            DTPdataNascimento.Format = DateTimePickerFormat.Custom;
            DTPdataNascimento.CustomFormat = "dd/MM/yyyy";
            cbmBoxCargo.Items.AddRange(new string[] { "Analista", "Desenvolvedor", "Gerente" });
            if (Globals.idEmEdicao != null)
            {
                SetFuncionario();
            }
            LoadData();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!ValidName(txtNomeCompleto.Text))
                {
                    MessageBox.Show("Nome inválido",
                        "Erro no preenchimento do formulário.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtNomeCompleto.Text = "";
                }
                else if (!CPFValidator.IsValid(maskedTxtCPF.Text))
                {
                    MessageBox.Show("CPF inválido",
                        "Erro no preenchimento do formulário.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    maskedTxtCPF.Text = "";
                }
                else if (cbmBoxCargo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um cargo",
                        "Erro no preenchimento do formulário.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else if (btnSalvar.Text == "Salvar")
                {
                    Funcionario func = new Funcionario();

                    func.Id = Guid.NewGuid().ToString();
                    func.Nome = txtNomeCompleto.Text;
                    func.CPF = maskedTxtCPF.Text;
                    func.Cargo = cbmBoxCargo.SelectedItem.ToString();
                    func.DataNascimento = DTPdataNascimento.Value.Date;

                    Globals.listaFuncionarios.Add(func);

                    LoadData();
                    ClearFields();

                    MessageBox.Show("Funcionário Cadastrado com Sucesso",
                        "Sucesso!",
                        MessageBoxButtons.OK);
                }
                else
                {
                    var func = Globals.listaFuncionarios.FirstOrDefault(f => f.Id == Globals.idEmEdicao);
                    if (func != null)
                    {
                        func.Nome = txtNomeCompleto.Text;
                        func.CPF = maskedTxtCPF.Text;
                        func.Cargo = cbmBoxCargo.SelectedItem.ToString();
                        func.DataNascimento = DTPdataNascimento.Value.Date;
                    }
                    LoadData();
                    ClearFields();
                    Globals.idEmEdicao = null;
                    btnSalvar.Text = "Salvar";
                    btnDeletar.Enabled = false;
                    MessageBox.Show("Funcionário Editado com Sucesso",
                        "Sucesso!",
                        MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro no preenchimento do formulário.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }


        

        private void dataVisualizacao_DoubleClick(object sender, EventArgs e)
        {
            if (dataVisualizacao.CurrentRow.Index != -1)
            {

                if (dataVisualizacao.CurrentRow.Cells["Id"].Value != null)
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (Globals.idEmEdicao == null)
            {
                MessageBox.Show("Selecione um funcionário para deletar.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este funcionário?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                var funcionario = Globals.listaFuncionarios.FirstOrDefault(f => f.Id == Globals.idEmEdicao);

                if (funcionario != null)
                {
                    Globals.listaFuncionarios.Remove(funcionario);
                    LoadData();
                    ClearFields();
                    Globals.idEmEdicao = null;

                    MessageBox.Show("Funcionário deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("A exclusão foi cancelada.");
            }
        }

        private void btnCalculoImposto_Click(object sender, EventArgs e)
        {
            Form form = new Form2();

            form.Show();

            this.Hide();
        }
    }
}
