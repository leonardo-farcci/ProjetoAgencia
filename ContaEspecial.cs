using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ContaEspecial : Conta
    {
        double limite;

        public double Limite
        {
            get
            {
                return this.limite;
            }

            set
            {
                limite = value;
            }
        }

        public ContaEspecial () : base () { }
        
        public ContaEspecial(string nConta, string nome, DateTime dataAbertura, double saldo, double limite) 
            : base(nConta, nome, dataAbertura, saldo)
        {
            this.Limite = limite;
        }            

        public virtual bool saldoSacar(double valor)
        {
            if(Saldo >= valor)
            {
                return true;
            }else{
                return false;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nLimite: " + Limite;
        }


    }
}
