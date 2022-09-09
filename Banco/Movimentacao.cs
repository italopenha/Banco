using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Movimentacao
    {
        public string Tipo { get; set; }

        public decimal Valor { get; set; }

        public Movimentacao(string tipo, decimal valor)
        {
            Tipo = tipo;
            Valor = valor;
        }
    }
}
