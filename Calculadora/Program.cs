using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
            }

            switch (operacao)
            {
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
            }

            switch (operacao)
            {
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
            }

            switch (operacao)
            {
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }

                default:
                    Console.WriteLine("Número invalido, digite um válido.");
                    break;
            }

            Console.WriteLine("O resultado com os números {0} e {1} é: {2}", num1, num2, resultado);

            Console.ReadLine();
        }

        public static int Adicao (int numero1, int numero2){
            int resultado = numero1 + numero2; 
            return resultado;
            }

        public static int Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
