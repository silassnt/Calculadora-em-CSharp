using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {

            bool escolheusair = false;

            while (!escolheusair)
            {
                Console.WriteLine("Seja bem vindo à Calculadora, por favor selecione uma opção");
                Console.WriteLine("1-Soma\n2-Subrtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opção = (Menu)int.Parse(Console.ReadLine());

                switch (opção)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtração:
                        Sub();
                        break;
                    case Menu.Divisão:
                        Div();
                        break;
                    case Menu.Multiplicação:
                        Multi();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheusair = true;
                        break;
                }
                Console.Clear();

            }



        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Multi()
        {
            Console.WriteLine("Multiplicação de dois números");
            Console.WriteLine("Digite o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potência de um número");
            Console.WriteLine("Digite a base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número");
            Console.WriteLine("Digite o número:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Aperte ENTER para voltar ao menu");
            Console.ReadLine();
        }


    }
}
