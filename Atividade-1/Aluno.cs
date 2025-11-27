using System;

namespace Atividade_1
{
    public class Aluno
    {
        private int _idade; //campo privado para armazenar a idade

		private double _nota; //campo privado para armazenar a nota

		public String Nome { get; set; } //propriedade funcionando como um parametro para o nome do aluno
            
		public int Idade //deixa o objeto idade acessivel para conferir e modificar
        {
            get => _idade; 
			set //validação para devolver o objeto para ser maior que 0 | validação feita antes de alterar
            {   
                if (value < 0)
                {
                    Console.WriteLine("Idade não pode ser negativa.");
                }
                else
                {
                    _idade = value;
				}
            }
		}
        public double Nota
        {
            get => _nota;
            set
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("Nota deve ser entre 0 a 10.");
                else
                {
                    _nota = value;
				}
            }
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Nota: {Nota}";
        }
    }
}
