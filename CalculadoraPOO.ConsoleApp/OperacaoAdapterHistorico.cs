using System;

namespace CalculadoraPOO.ConsoleApp
{
    //implementando a interface, caso queira mais metodos para adaptar
    public class OperacaoAdapterHistorico : ITarget
    {
        //O Adapter vai usar esta classe para reutilizar a funcionalidade existente e modificá-la para o uso desejado.
        private Historico historico = new Historico();
        public void HistoricoVerde(Operação operação)
        {
            //apenas um exemplo simples, em que podemos manipular o metodo dentro dessa classe, porem não mudando dentro da propria classe
            Console.ForegroundColor = ConsoleColor.Green;
            
            //utilizando o metodo da forma comum
            historico.MostrarHistorico(operação);
            Console.ResetColor();
        }
    }
}
