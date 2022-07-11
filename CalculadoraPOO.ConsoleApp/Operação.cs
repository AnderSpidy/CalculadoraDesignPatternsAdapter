using System;

namespace CalculadoraPOO.ConsoleApp
{
    public class Operação
    {
       
        public Resultado[] resultados;

       
        public void Somar()
        {
            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("ADIÇÃO");
            Console.WriteLine("Primeiro numero: ");
            double primeiroNumeroSoma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double segundoNumeroSoma = Convert.ToInt32(Console.ReadLine());
            double resultado = primeiroNumeroSoma + segundoNumeroSoma;
            Console.WriteLine("O resultado da adição é " + resultado);
            Console.WriteLine("\n--------------------\n");
            for (int i = 0; i < this.resultados.Length; i++)
            {
                if (this.resultados[i] == null)
                {
                    Resultado resultadoSoma = new Resultado();
                    resultadoSoma.resultadoOperacao= "A " + (i+1) + "º operação: " + primeiroNumeroSoma + " + " + segundoNumeroSoma + " = " + resultado + "\n";
                    resultados[i] = resultadoSoma;
                    break;
                }
            }
        }


        public void Subtrair()
        {
            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("SUBTRAÇÃO");
            Console.WriteLine("Primeiro numero: ");
            double primeiroNumeroSubtrair = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double segundoNumeroSubtrair = Convert.ToInt32(Console.ReadLine());
            
            double resultado = primeiroNumeroSubtrair - segundoNumeroSubtrair;
            Console.WriteLine("O resultado da subtração é " + resultado);
            Console.WriteLine("\n--------------------\n");
            for (int i = 0; i < this.resultados.Length; i++)
            {
                if (this.resultados[i] == null)
                {
                    Resultado resultadoSoma = new Resultado();
                    resultadoSoma.resultadoOperacao = "A " + (i+1) + "º operação: " + primeiroNumeroSubtrair + " - " + segundoNumeroSubtrair + " = " + resultado + "\n";
                    resultados[i] = resultadoSoma;
                    break;
                }
            }
        }

        public void Divisão()
        {
            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("DIVISÃO");
            Console.WriteLine("Primeiro numero: ");
            double primeiroNumeroDividir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double segundoNumeroDividir = Convert.ToInt32(Console.ReadLine());

            if (segundoNumeroDividir != 0)
            {
                double resultado = ((double)primeiroNumeroDividir / segundoNumeroDividir);
                Console.WriteLine("O resultado da Divisão é " + resultado);
                Console.WriteLine("\n--------------------\n");
                for (int i = 0; i < this.resultados.Length; i++)
                {
                    if (this.resultados[i] == null)
                    {
                        Resultado resultadoSoma = new Resultado();
                        resultadoSoma.resultadoOperacao = "A " + (i+1) + "º operação: " + primeiroNumeroDividir + " / " + segundoNumeroDividir + " = " + resultado + "\n";
                        resultados[i] = resultadoSoma;
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Não é posivel divisão com o numero 0!!!");
            }
        }

        public  void Multiplicar()
        {
            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("MULTPLICAÇÃO");
            Console.WriteLine("Primeiro numero: ");
            double primeiroNumeroMultiplicar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double segundoNumeroMultiplicar = Convert.ToInt32(Console.ReadLine());

            double resultado = primeiroNumeroMultiplicar * segundoNumeroMultiplicar;
            Console.WriteLine("O resultado da multplicação é " + resultado);
            Console.WriteLine("\n--------------------\n");
            for (int i = 0; i < this.resultados.Length; i++)
            {
                if (this.resultados[i] == null)
                {
                    Resultado resultadoSoma = new Resultado();
                    resultadoSoma.resultadoOperacao = "A " + (i+1) + "º operação: " + primeiroNumeroMultiplicar + " * " + segundoNumeroMultiplicar + " = " + resultado + "\n";
                    resultados[i] = resultadoSoma;
                    break;
                }
            }
        }

        public void RestoDivisão()
        {
            Console.WriteLine("\n--------------------\n");
            Console.WriteLine("RESTO DA DIVISÃO");
            Console.WriteLine("Primeiro numero: ");
            double primeiroNumeroResto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            double segundoNumeroResto = Convert.ToInt32(Console.ReadLine());

            if (segundoNumeroResto != 0)
            {
                double resultado = ((double)primeiroNumeroResto % segundoNumeroResto);
                Console.WriteLine("O o resto da Divisão é " + resultado);
                for (int i = 0; i < this.resultados.Length; i++)
                {
                    if (this.resultados[i] == null)
                    {
                        Resultado resultadoSoma = new Resultado();
                        resultadoSoma.resultadoOperacao = "A " + (i+1) + "º operação: " + primeiroNumeroResto + " % " + segundoNumeroResto + " = o resto da divisão é " + resultado + "\n";
                        resultados[i] = resultadoSoma;
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Não é posivel divisão com o numero 0!!!");
            }
        }
    }
}