using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_23082022
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis para entrar com os numeros
            int n1, n2;

            //Solicitar os numeros
            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            // Mostrar menu de opcoes
            Console.WriteLine(("Escolha uma opção da lista:"));
            Console.WriteLine("1 para somar");
            Console.WriteLine("2 para subtrair");
            Console.WriteLine("3 para multiplicar");
            Console.WriteLine("4 para dividir");

            //Realizar a ação de acordo com a opção escolhida
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("A soma dos valores é = " + (n1+n2));
                    break;
                case "2":
                    Console.WriteLine("A subtração dos valores é = " + (n1-n2));
                    break;
                case "3":
                    Console.WriteLine("A multiplicação dos valores é =  " + (n1*n2));
                    break;
                case "4":
                    Console.WriteLine("A divisão dos valores é = " + (n1/n2));
                    break;

            }
            Console.Write("Pressione qq tecla para fechar o aplicativo");
            Console.ReadKey();
        }
    }
}
