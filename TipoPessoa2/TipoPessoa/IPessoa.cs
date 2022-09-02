using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoPessoa
{
    public interface IPessoa
    {
        TipoPessoa CriarPessoa(string tipo);
    }
}
