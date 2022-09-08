using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratoPedido
{
    public class Prato
    {
        //Atributos
        public string _nome { get; set; }
        public string _descricao { get; set; }
        public string _categoria { get; set; }
        public string _subcategoria { get; set; }
        public string _unidademedida { get; set; }
        public string _armazenagem { get; set; }
         
        public bool _status { get; set; }
        public int _quantidade { get; set; }
        public decimal _precocompra { get; set; }
        public decimal _precovenda { get; set; }
        public decimal _precolucro { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------");
            sb.AppendLine("Nome: " + this._nome);
            sb.AppendLine("Descricao: " + this._descricao);
            sb.AppendLine("Categoria: " + this._categoria);
            sb.AppendLine("Subcategoria: " + this._subcategoria);
            sb.AppendLine("Unidademedida: " + this._unidademedida);
            sb.AppendLine("Armazanagem: " + this._armazenagem);
            sb.AppendLine("Status: " + this._status);
            sb.AppendLine("Quantidade: " + this._quantidade);
            sb.AppendLine("Precocompra: " + this._precocompra.ToString("#,##0.00"));
            sb.AppendLine("Precovenda: " + this._precovenda.ToString("#,##0.00"));
            sb.AppendLine("Precolucro: " + this._precolucro.ToString("#,##0.00"));
            sb.AppendLine("----------------------");
            return sb.ToString();

        }
    }
}