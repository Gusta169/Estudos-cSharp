namespace Estudos_c_
{
    class Pessoa
    {
        public string Nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e minha idade é {idade} anos");
        }
    }
}
