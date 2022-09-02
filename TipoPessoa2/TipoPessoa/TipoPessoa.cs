using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoPessoa
{
    public class TipoPessoa
    {
        public string nome;
        public string endereco;
        public int teleforne;
        public string email;
        public string tipo;

        public static void alterEmail(string email)
        {
            Console.WriteLine("\nA seu novo email é = " + email);
        }

        public static void alterEndereco(string endereco)
        {
            Console.WriteLine("O seu novo endereço é: " + endereco);
        }
    }
}
