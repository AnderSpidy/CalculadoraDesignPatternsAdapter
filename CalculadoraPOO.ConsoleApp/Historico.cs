using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO.ConsoleApp
{
    public class Historico
    {
        //está classe apenas recebe as operações que estão armazenados no array de resultados na classe main, para imprimilos na tela 
        public void MostrarHistorico(Operação operação)
        {
            if (operação.resultados[0] == null)
            {
                Console.WriteLine("Não foi registrado operações até o momento!");
                return;
            }
            for (int i = 0; i < operação.resultados.Length; i++)
            {

                if (operação.resultados[i] != null)
                {
                    Console.WriteLine(operação.resultados[i].resultadoOperacao);
                }
            }
        }
    }
}
