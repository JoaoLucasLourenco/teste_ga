using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_ga.Models
{
    public class ImpostoFuncionario
    {
        public string Id { get; set; }
        public string NomeFuncionario { get; set; }
        public string CargoFuncionario { get; set; }
        public DateTime DataCalculo { get; set; }
        public string Salario { get; set; }
        public string Imposto { get; set; }
    }
}
