using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ex06
    {
        private static void main(string[] args)
        {
            int p1, p2, media;

            Console.WriteLine("Digite a nota da P1: ");
            p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a nota da P2: ");
            p2 = Convert.ToInt32(Console.ReadLine());

            media = p1 + p2 * 2 / 3;

            Console.WriteLine("A média total do Aluno é: " + media);

        }
    }
}
