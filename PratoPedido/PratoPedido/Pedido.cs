using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratoPedido
{
    public class Pedido : Prato
    {
        private List<Prato> _prato;
        public int _registros = 0;

        public Pedido()
        {
            _prato = new List<Prato>();
        }

        public void AdicionarPrato(Prato prato)
        {
            this._prato.Add(prato);
            _registros++;
        }

        public Prato this[int indice]
        {
            get
            {
                if (indice < this._prato.Count)
                    return this._prato[indice];
                else
                    throw new IndexOutOfRangeException("O índice está fora dos limites!");
            }

            set
            {
                this._prato[indice] = value;
            }
        }
    }
}
