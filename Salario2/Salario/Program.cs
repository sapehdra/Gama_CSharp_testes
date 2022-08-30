using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salario2_25082022
{

    internal class Program
    {
        static void Main(string[] Args)
        {
            //Declaração das variaveis
            string nome;

            int sal, h;

            //Solicitar dados
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            sal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite suas horas trabalhadas: ");
            h = Convert.ToInt32(Console.ReadLine());

            //Menu de opções
            Console.WriteLine( nome + " Escolha uma das opções abaixo: ");
            Console.WriteLine("Digite D para salário p/ dia ");
            Console.WriteLine("Digite S para salário p/ semanal ");
            Console.WriteLine("Digite A para salário p/ anual ");
            Console.WriteLine("Digite H para salário p/ hora ");

            //Escolha da operação e mostrar resultado na tela
            switch(Console.ReadLine()){
                case "D":
                Console.WriteLine(nome + $" Seu salário por dia é {sal}/{30} = " + (sal/30));
                break;
                case "S":
                Console.WriteLine(nome + $" Seu salário por semana é {sal}/{4} = " + (sal/4));
                break;
                case "A":
                Console.WriteLine(nome + $" Seu salário por dia é {sal}*{12} = " + (sal*12));
                break;
                case "H":
                Console.WriteLine(nome + $" Seu salário por hora é {sal}/{h} = " + (sal/h));
                break;
            }
           
        }
    }
}
