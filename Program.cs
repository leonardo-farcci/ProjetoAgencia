using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta("44444444", "TAMURA", DateTime.Parse("10/02/2017"), 50000);
            ContaEspecial e = new ContaEspecial("5555555", "LEONARDO", DateTime.Parse("10/10/10"), 50000000, 10000000000);

            Console.WriteLine(c);
            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}
