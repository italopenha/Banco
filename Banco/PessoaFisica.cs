using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    // Exemplo de herança, onde a classe PessoaFisica é derivada da classe Cliente.
    public class PessoaFisica : Cliente 
    {
        public PessoaFisica(string codigo, string nome) : base(codigo, nome)
        { }

        // Exemplo de polimorfismo, onde o método DescontarTaxa da classe Cliente, assume outro comportamento.
        public override decimal DescontarTaxa(decimal valor) 
        {
            return valor - 1;
        }
    }
}
