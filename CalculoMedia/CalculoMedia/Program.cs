using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcumoMedia_23082022
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;

            int n1, n2, n3, n4;

            //Solicitar dados
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Insira sua Nota 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira sua Nota 2: ");
            n2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Insira sua Nota 3: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira sua Nota 4: ");
            n4 = Convert.ToInt32(Console.ReadLine());

            // Mostrar menu de opcoes
            Console.WriteLine(nome+ " Sua média é: " +(n1+n2+n3+n4)/4);

        }
    }
}
