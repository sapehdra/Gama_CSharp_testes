using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoPessoa
{
    public class criar_pessoa_RJ : IPessoa
    {
        public TipoPessoa definirFuncPublico()
        {
            return new TipoPessoa();
        }

        public TipoPessoa CriarPessoa(string tipo)
        {
            return new TipoPessoa()
            {
                tipo = "Pessoa Física"
            };
            
        }

     }   
}        
