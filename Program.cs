using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;

            Console.Write("Digite um nome: ");

            nome1 = Console.ReadLine();
            Console.Write("Digite outro nome: ");

            nome2 = Console.ReadLine();

            if (nome1 == nome2)

            {

                Console.Write("O nomes são iguais.");

            }
            else

            {

                Console.Write("Os nomes são diferentes.");

            }



            Console.ReadLine();
        }
    }
}
