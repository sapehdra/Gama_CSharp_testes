using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salario_23082022
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis
            string nome;

            int sal, salD, salS, salM, salA, salH;

            //Solicitar dados
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário: ");
            sal = Convert.ToInt32(Console.ReadLine());

            //Menu de opções
            Console.WriteLine( nome + " Escolha uma das opções abaixo: ");
            Console.WriteLine("Digite D para salário p/ dia ");
            Console.WriteLine("Digite S para salário p/ semanal ");
            Console.WriteLine("Digite M para salário p/ mensal ");
            Console.WriteLine("Digite A para salário p/ anual ");
            Console.WriteLine("Digite H para salário p/ hora ");

            //Escolha da operação e mostrar resultado na tela
            switch(Console.ReadLine()){
                case "D":
                Console.WriteLine(nome + " Seu salário por dia é: " + (salD = sal / 30));
                break;
                case "S":
                Console.WriteLine(nome + " Seu salário por semana é: " + (salS = sal/4));
                break;
                case "M":
                Console.WriteLine(nome + " Seu salário por mês é: " + (salM = sal));
                break;
                case "A":
                Console.WriteLine(nome + " Seu salário por dia é: " + (salA = sal*12));
                break;
                case "H":
                Console.WriteLine(nome + " Seu salário por hora é: " + (salH = sal/220));
                break;
            }
           
        }
    }
}
