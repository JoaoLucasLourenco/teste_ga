using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_ga.Models
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; } = null;
        public string CPF { get; set; } = null;
        public string Cargo { get; set; } = null;
        public DateTime DataNascimento { get; set; }

    }
}
