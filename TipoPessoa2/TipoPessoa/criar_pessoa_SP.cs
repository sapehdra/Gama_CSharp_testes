using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoPessoa
{
    public class criar_pessoa_SP : IPessoa
    {
        public TipoPessoa criarlocal()
        {
            return new TipoPessoa();

        }
        public TipoPessoa CriarPessoa(string tipo)
        {
            return new TipoPessoa()
            {
                tipo = "casa"
            };
        }
    }
}
