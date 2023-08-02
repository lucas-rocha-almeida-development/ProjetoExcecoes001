using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExcecoes001.Entitedes.Exceptions
{
    internal class DominioExcecao : ApplicationException
    {

        //construtor ( execeção personalizada)
        public DominioExcecao(string mensagem):base(mensagem) 
        { 

        }
    }
}
