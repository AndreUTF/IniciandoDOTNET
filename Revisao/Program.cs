using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = displayRead();
                        
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario){
                    case "1":
                        Aluno aluno = new Aluno();
                        Console.WriteLine("Informe o nome do aluno:");
                        aluno.Name = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        aluno.Grade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nota e nome inseridos");
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;
                    case "2":
                        //TODO - Listar alunos
                        foreach(var a in alunos)
                        {
                            if(a != null)
                            {
                                Console.WriteLine($"Aluno nome, nota: {a.Name} , {a.Grade}");
                            }
                            
                        }
                        break;
                    case "3":
                        //TODO - calcular media geral
                        var notaTotal = 0;
                        indiceAluno = 0;
                        foreach( var b in alunos)
                        {
                           if(b != null)
                           {
                               notaTotal += b.Grade;
                               indiceAluno++;
                           } 
                        }
                        Console.WriteLine("Media eh" + (notaTotal/indiceAluno));
                        int mediaGeral = notaTotal/indiceAluno;
                        Conceito conceitoGeral;
                        
                        if(mediaGeral < 30)
                        {
                            conceitoGeral = Conceito.E;
                        }
                        else if (mediaGeral < 40)
                        {
                            conceitoGeral = Conceito.D; 
                        }
                        else if (mediaGeral < 60)
                        {
                            conceitoGeral = Conceito.C;
                        }
                        
                        else if (mediaGeral < 80)
                        {
                            conceitoGeral = Conceito.B;
                        }
                        else
                        {
                            conceitoGeral = Conceito.A;
                        }
                        Console.WriteLine("Conceito geral é: " + conceitoGeral
                                         + " , mmedia é: " + mediaGeral);
                        
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = displayRead();
            }
        }

        public static string displayRead()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string str = Console.ReadLine();
            return str;
        }

        private static ConsoleKeyInfo GetStr()
        {
            return Console.ReadKey();
        }
    }
}
