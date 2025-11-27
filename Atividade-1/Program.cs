using System;
using System.Collections.Generic;
using System.Linq;

namespace Atividade_1
{
    class Program //Classe Principal do aplicativo
    {
        static void Main(string[] args) //Ponto de entrada do programa, executado automaticamente quando o aplicativo é iniciado.
        {
            GerenciadorAluno gerenciador = new GerenciadorAluno(); //criação do objeto da classe
            List<Aluno> alunos = new List<Aluno>(); 

            while (true)
            {
                Console.WriteLine("1 - Adicionar aluno");
                Console.WriteLine("2 - Lista alunos");
                Console.WriteLine("3 - Buscar aluno pelo nome");
                Console.WriteLine("4 - Remover aluno");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                int escolha = int.Parse(Console.ReadLine())!; //utilização do Parse para forçar a string ser int

                switch (escolha)
                {
                    case 1:
                        AdicionarAluno(alunos);
                        break;
                    case 2:
                        gerenciador.ListarAlunos();
                        break;
                    case 3:
                        {
                            Console.Write("Digite o nome do aluno para buscar: ");
                            string nome = Console.ReadLine()!;
                            gerenciador.BuscarAluno(nome);
                            break;
                        }
                        
                    case 4:
                        {
                            Console.Write("Digite o nome do aluno para remover: ");
                            string nome = Console.ReadLine()!;
                            gerenciador.RemoverAluno(nome);
                            break;
                        }
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void AdicionarAluno(List<Aluno> alunos)
        {
            Aluno novoAluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            novoAluno.Nome = Console.ReadLine();
            Console.Write("Digite a idade do aluno: ");
            novoAluno.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do aluno: ");
            novoAluno.Nota = double.Parse(Console.ReadLine());
            alunos.Add(novoAluno);
            Console.WriteLine("Aluno adicionado com sucesso!");
        }
    }
}