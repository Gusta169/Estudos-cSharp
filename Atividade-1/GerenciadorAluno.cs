using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_1
{
    internal class GerenciadorAluno
    {
        private List<Aluno> _alunos = new List<Aluno>(); 

        public void AdicionarAluno(Aluno aluno)
        {
            _alunos.Add(aluno);
        }
        public void ListarAlunos()
        {
            for (int i = 0; i < _alunos.Count; i++)
            {
                Console.WriteLine(_alunos[i]);
            }        
        }
        public Aluno BuscarAluno(String nome)
        {
            return _alunos.Find(a => a.Nome == nome); //Procura pelo nome na lista e retorna quando encontrar ou retorna null se não achar
        }
        public void RemoverAluno(String nome)
        {
            Aluno alunoParaRemover = _alunos.Find(a => a.Nome == nome);

            if (alunoParaRemover != null)
            {
                _alunos.Remove(alunoParaRemover); //remove o objeto da lista
                Console.WriteLine($"O aluno {nome} foi removido");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado");
            }
        }
    }
}
