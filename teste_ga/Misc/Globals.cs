using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_ga.Models;

namespace teste_ga.Misc
{
    public static class Globals
    {
        private static BindingList<Funcionario> _funcionarios = new BindingList<Funcionario>();
        public static BindingList<Funcionario> listaFuncionarios => _funcionarios;

        private static BindingList<ImpostoFuncionario> _impostoFuncionario = new BindingList<ImpostoFuncionario>();
        public static BindingList<ImpostoFuncionario> listaImpostoFuncionario => _impostoFuncionario;

        public static string idEmEdicao = null;

        public static readonly decimal[] IR_Limites = { 2000.00m, 3000.00m, 4500.00m };
        public static readonly decimal[] IR_Porcentagens = { 0.08m, 0.18m, 0.28m };
    }
}
