using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    
    public class Cliente // Classe base
    {
        public string Codigo { get; private set; }

        public string Nome { get; private set; }

        public decimal Saldo { get; private set; }

        public List<Movimentacao> Movimentacoes { get; set; }

        public Cliente() // Contrutor padrão da lista de movimentações
        {
            Movimentacoes = new List<Movimentacao>();
        }

        public Cliente(string codigo, string nome) : this() // this serve para chamar o construtor padrão onde está a lista.
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void RealizarSaque(decimal valor)
        {
            if (Saldo > valor)
            {
                decimal valorMenosTaxa = DescontarTaxa(valor);
                Saldo = Saldo - valor;
                AdicionarMovimentacao("SAQUE", valorMenosTaxa);
                Console.WriteLine($"Saque realizado com sucesso. Saldo {Saldo}");
            }
            else
                Console.WriteLine("Valor insuficiente");
        }

        public void RealizarDeposito(decimal valor)
        {
            if (valor > 0)
            {
                decimal valorMenosTaxa = DescontarTaxa(valor);
                Saldo += valorMenosTaxa;
                AdicionarMovimentacao("DEPÓSITO", valorMenosTaxa);
                Console.WriteLine($"Depósito realizado com sucesso. Saldo: {Saldo}");
            }
            else if (valor <= 0)
                Console.WriteLine("Valor deve ser maior que zero");
        }

        private void AdicionarMovimentacao(string tipo, decimal valor)
        {
            Movimentacoes.Add(new Movimentacao(tipo, DescontarTaxa(valor)));
        }

        public virtual decimal DescontarTaxa(decimal valor)
        {
            return valor;
        }
    }
}
