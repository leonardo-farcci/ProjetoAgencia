using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Conta
    {
        string nConta;
        string nome;
        DateTime dataAbertura;
        double saldo;

        public string NConta
        {
            get
            {
                return nConta;
            }

            set
            {
                nConta = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataAbertura
        {
            get
            {
                return dataAbertura;
            }

            set
            {
                dataAbertura = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public Conta() { }

        public Conta(string nConta, string nome, DateTime dataAbertura, double saldo)
        {
            this.NConta = nConta;
            this.Nome = nome;
            this.DataAbertura = dataAbertura;
            this.Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            saldo = Saldo + valor;
        }

        public void Sacar(double valor)
        {
            saldo = Saldo - valor;
        }

        public override string ToString()
        {
            return "\nConta: " + NConta + "\nNome: " + Nome + "\nData da abertura: " + DataAbertura.ToShortDateString() + "\nSaldo: " + saldo;
        }
    }
}
