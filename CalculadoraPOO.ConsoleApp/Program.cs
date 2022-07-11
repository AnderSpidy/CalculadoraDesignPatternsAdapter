using System;
using System.Collections.Generic;

namespace CalculadoraPOO.ConsoleApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            Operação operação = new Operação();
            operação.resultados = new Resultado[100];

            //E usado a interface para que usar como "Forma" na instanciação da classe Adapter
            ITarget target = new OperacaoAdapterHistorico();
            
            string opcao = "";
            while (opcao != "s")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("Calculadora Topzera!!! 1.5");
                Console.WriteLine("Digite 1 para somar ");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para obter o resto da divisão");
                Console.WriteLine("Digite 6 para obter os historicos");
                Console.WriteLine("Digite 's' para fechar o progama");
                opcao = Console.ReadLine();

                switch (opcao)
                {

                    case "1":
                       
                        operação.Somar();
                        break;

                    case "2":
                        
                        operação.Subtrair();
                        break;

                    case "3":
                        
                        operação.Multiplicar();
                        break;

                    case "4":
                        
                        operação.Divisão();
                        break;

                    case "5":
                        
                        operação.RestoDivisão();
                        break;

                    case "6":
                        //utiliza o metodo atravéz da interface adaptadora, que tera as alterações que programou
                        target.HistoricoVerde(operação);
                        break;

                    case "s":
                        Console.WriteLine("FECHAR CALCULADORA\nATÉ A PROXIMA!!!");
                        break;
                   
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA.\n DIGITE UMA DAS OPÇÕES SUGERIDAS NO MENU!!!");
                        break;

                }
                
                Console.ReadLine();
            }
            #region Resolução apenas com While
            //.....................................OPÇÃO SEM SWITCH CASE..........................
            //.....................................APENAS COM WHILE..............................


            /*string opcao = "";
            while(opcao != "s")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("Calculadora Topzera!!! 1.5");
                Console.WriteLine("Digite 1 para somar ");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para obter o resto da divisão");
                Console.WriteLine("Digite 's' para fechar o progama");
                opcao = Console.ReadLine();
                
                Console.WriteLine("-------------------------");
                if (opcao == "s")
                    {
                    break;
                    }
                else if ( opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4" || opcao == "5")
                { 

                    Console.WriteLine("Primeiro numero: ");
                    string strPrimeiroNumero = Console.ReadLine();
                    Console.WriteLine("Segundo numero: ");
                    string strSegundoNumero = Console.ReadLine();

                   

                    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
                    int segundoNumero = Convert.ToInt32(strSegundoNumero);
                    if (opcao == "1")
                    {
                        int resultado = primeiroNumero + segundoNumero;
                        Console.WriteLine("O resultado da adição é " + resultado);


                    }
                    else if (opcao == "2")
                    {
                        int resultado = primeiroNumero - segundoNumero;
                        Console.WriteLine("O resultado do subtração é " + resultado);

                    }
                    else if (opcao == "3")
                    {
                        int resultado = primeiroNumero * segundoNumero;
                        Console.WriteLine("O resultado da multiplicação é " + resultado);

                    }
                    else if (opcao == "4")
                    {
                        if (segundoNumero != 0)
                        {
                            float resultado = ((float)primeiroNumero / segundoNumero);
                            Console.WriteLine("O resultado da Divisão é " + resultado);

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }
                    }
                    else if (opcao == "5")
                    {
                        if (segundoNumero != 0)
                        {
                            float resultado = ((float)primeiroNumero % segundoNumero);
                            Console.WriteLine("O o resto da Divisão é " + resultado);

                        }
                        else
                        {
                            Console.WriteLine("Não é posivel divisão com o numero 0!!!");
                        }
                    }

                }

                Console.WriteLine("-----------------------");
                Console.ReadLine();            
            }*/
            #endregion
        }
    }
}


