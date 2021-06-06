using System;

namespace Exercicio_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Valor = 0, Valor2 = 1;
                int Termos;       
                    int Somas;
          

                 Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("Digite a Quantidade de Termos: ");
                Termos = int.Parse(Console.ReadLine());
               
                 Console.ResetColor();

                Somas = Valor + Valor2;

                Console.WriteLine();
                Console.Write(0 + " " + 1 + " ");
                

                 for (int i = 3; i <= Termos; i++)
                {
                    Console.Write(Somas + " ");
                    Valor = Valor2;
                    Valor2 = Somas;
                    Somas = Valor + Valor2;
                }
        }
    }
}
