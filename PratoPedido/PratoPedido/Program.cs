using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PratoPedido
{
    public class Program : Pedido
    {
        static void Main(string[] Args)
        {
            try
            {
                Pedido pedido = new Pedido();

                pedido.AdicionarPrato(new Prato()
                {
                    _nome = "Cuscuz com ovo",
                    _descricao = "Cuscuz e ovo",
                    _categoria = "Comida de sal",
                    _subcategoria = "Nordestina",
                    _unidademedida = "300g",
                    _armazenagem = "Feito na hora",
                    _status = true,
                    _quantidade = 10,
                    _precocompra = 2,
                    _precovenda = 4,
                    _precolucro = 2,

                });

                pedido.AdicionarPrato(new Prato()
                {
                    _nome = "Baião de dois",
                    _descricao = "Arroz, feijão e torresmo cozido junto",
                    _categoria = "Comida de sal",
                    _subcategoria = "Nordestina",
                    _unidademedida = "500g",
                    _armazenagem = "Feito na hora",
                    _status = false,
                    _quantidade = 0,
                    _precocompra = 4,
                    _precovenda = 6,
                    _precolucro = 2,

                });

                pedido.AdicionarPrato(new Prato()
                {
                    _nome = "Bananada",
                    _descricao = "Vitamina de Banana",
                    _categoria = "Bebida",
                    _subcategoria = "Vitamina",
                    _unidademedida = "500ml",
                    _armazenagem = "Feito na hora",
                    _status = true,
                    _quantidade = 10,
                    _precocompra = 3,
                    _precovenda = 4,
                    _precolucro = 1,

                });


                Console.WriteLine($"O pedido tem {pedido._registros} itens. Qual você deseja acessar?");
                int indice = int.Parse(Console.ReadLine());
                Console.WriteLine(pedido[indice].ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
