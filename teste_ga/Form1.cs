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

        BindingList<Funcionario> listaFuncionarios = new BindingList<Funcionario>();

        private string idEmEdicao = null;

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
            dataVisualizacao.DataSource = listaFuncionarios;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearFields();
            DTPdataNascimento.Format = DateTimePickerFormat.Custom;
            DTPdataNascimento.CustomFormat = "dd/MM/yyyy";
            cbmBoxCargo.Items.AddRange(new string[] { "Analista", "Desenvolvedor", "Gerente" });

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

                    listaFuncionarios.Add(func);

                    LoadData();
                    ClearFields();

                    MessageBox.Show("Funcionário Cadastrado com Sucesso",
                        "Sucesso!",
                        MessageBoxButtons.OK);
                }
                else
                {
                    var func = listaFuncionarios.FirstOrDefault(f => f.Id == idEmEdicao);
                    if (func != null)
                    {
                        func.Nome = txtNomeCompleto.Text;
                        func.CPF = maskedTxtCPF.Text;
                        func.Cargo = cbmBoxCargo.SelectedItem.ToString();
                        func.DataNascimento = DTPdataNascimento.Value.Date;
                    }
                    LoadData();
                    ClearFields();
                    idEmEdicao = null;
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
                btnSalvar.Text = "Editar";
                btnDeletar.Enabled = true;
                idEmEdicao = dataVisualizacao.CurrentRow.Cells["Id"].Value.ToString();
                idLbl.Text = "Id: " + idEmEdicao;
                idLbl.Visible = true;
                txtNomeCompleto.Text = dataVisualizacao.CurrentRow.Cells["Nome"].Value.ToString();
                maskedTxtCPF.Text = dataVisualizacao.CurrentRow.Cells["CPF"].Value.ToString();
                cbmBoxCargo.SelectedItem = dataVisualizacao.CurrentRow.Cells["Cargo"].Value.ToString();
                DTPdataNascimento.Value = Convert.ToDateTime(dataVisualizacao.CurrentRow.Cells["DataNascimento"].Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (idEmEdicao == null)
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
                var funcionario = listaFuncionarios.FirstOrDefault(f => f.Id == idEmEdicao);

                if (funcionario != null)
                {
                    listaFuncionarios.Remove(funcionario);
                    LoadData();
                    ClearFields();
                    idEmEdicao = null;

                    MessageBox.Show("Funcionário deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("A exclusão foi cancelada.");
            }
        }
    }
}
