using System;
using DIgitalInnovationOne;

namespace DIgitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int  numeroDeVezes = 10;

            for(int i=0;i<numeroDeVezes;i++)
            {
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");

            }
            var n = new Pilha();
            n.Empilha(1);
            n.Empilha(10);
            n.Empilha(100);
            Console.WriteLine(n.Desempilha());
            Console.WriteLine(n.Desempilha());
            Console.WriteLine(n.Desempilha());

            Declaracoes();
            String[] str = {"oi","mundo"};
            InstrucaoIf(str);
            InstrucaoSwitch(str);
        }

        static void Declaracoes()
        {
            int a = 1;
            int b = 2, c = 3;
            int e = a + b + c;
            Console.WriteLine(e);
        }

        static void InstrucaoIf(String[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum Argumento");
            }
            else if(args.Length == 1)
            {
                Console.Write("Um argumento");
            }
            else
            {
                Console.WriteLine($"Args.length {args.Length}");
            }
        }

        static void InstrucaoSwitch(String[] args)
        {
            int argsSize = args.Length;
            switch(argsSize){
                case 0:
                    Console.WriteLine("0 args");
                    break;
                case 1:
                    Console.WriteLine("1 args");
                    break;
                default:
                    Console.WriteLine($"{argsSize}argumentos");
                    break;
            }
        }


    }
}
