using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoPessoa
{
    internal class Program
    {
        static void Main(string[] args)

        {
            TipoPessoa TipoPessoa = new TipoPessoa();
            TipoPessoa.endereco = "Rua da Arena, 300 - CEP: 63400-000";
            Console.Write("Meu endereço é: " + TipoPessoa.endereco);
            PessoaFisica.alterEmail("fulano@gmail.com");
            PessoaFisica.alterEndereco(Console.ReadLine().ToUpper());
            PessoaFisica.pcd = true;

            PessoaJuridica PessoaJuridica = new PessoaJuridica();
            PessoaJuridica.alterEmail("sicrano@gmail.com");
            PessoaJuridica.nome = "ResinAdah";
            PessoaJuridica.numeroFunc = 15;
            Console.WriteLine("Voce é pcd: " + PessoaFisica.pcd + " E trabalha na: " + PessoaJuridica.nome);

            IPessoa ipessoa = new criar_pessoa_RJ();
            var tipopessoa = ipessoa.CriarPessoa("tipo");

            Console.WriteLine("Criar apenas:" + tipopessoa.tipo);

            Console.ReadLine();

        }
    }
}
