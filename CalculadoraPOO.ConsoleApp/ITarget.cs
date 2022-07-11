using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.ConsoleApp
{
    //Esta interface será implementada pelo Adapter irá usar este método para trocar a cor da fonte
    public interface ITarget
    {
        void HistoricoVerde(Operação operação);

    }
}
