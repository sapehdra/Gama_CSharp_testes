using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Salario3_26082022
{
    internal class CalculoSal
    {
        static void Main(string[] args)
        {
            //Declaração das variaveis
            string nome;
            int sal, h;
            bool cont = true;

            
            

                Console.WriteLine("Por favor digite seu nome: ");
                nome = (Console.ReadLine());

                Console.WriteLine("Olá " + nome + " digite seu salário: ");
                sal = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Agora digite as horas trabalhadas esse mês: ");
                h = Convert.ToInt16(Console.ReadLine());

                //Menu de opções
                Console.WriteLine(nome + " Escolha uma das opções abaixo: ");
                Console.WriteLine("Digite D para salário p/ dia ");
                Console.WriteLine("Digite S para salário p/ semanal ");
                Console.WriteLine("Digite A para salário p/ anual ");
                Console.WriteLine("Digite H para salário p/ hora ");
                Console.WriteLine("Digite E para encerrar a aplicação ");


            while (cont)
            {

                switch (Console.ReadLine())
                {
                    case "D":
                        Console.WriteLine(nome + " Seu salário por dia é: " + (sal / 30));
                        break;
                    case "S":
                        Console.WriteLine(nome + " Seu salário por semana é: " + (sal / 4));
                        break;
                    case "A":
                        Console.WriteLine(nome + " Seu salário por dia é: " + (sal * 12));
                        break;
                    case "H":
                        Console.WriteLine(nome + " Seu salário por hora é: " + (sal / h));
                        break;
                    case "E":
                        cont = false;
                        Console.WriteLine("Pressione qualquer tecla para fechar o console!");
                        break;

                    default:
                        cont = true;
                        Console.WriteLine("Opção inválida! Tente de novo " + nome);
                        break;
                }
            }
            
        }
    }
}