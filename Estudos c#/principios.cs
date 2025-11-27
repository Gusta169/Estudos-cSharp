using Estudos_c_;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine($"Hello world"); //printar na tela

//Variaveis
int idade = 14;
int idade2 = 15;
String nome = "Gustavo"; //criação de variavel
bool booleana1 = true;
bool booleana2 = true;
bool booleana3 = false;

//estrutura de controles
if (idade == idade2)
{
    Console.WriteLine($"São iguais");
}
else
{
    Console.WriteLine($"Não são iguais");
}

if (booleana1 && booleana2) //operador && é para rodar quando ambas forem verdadeiras
{
    Console.WriteLine($"Ambas verdadeiras");
}

if (booleana1 || booleana3) //operador || é para quando alguma das 2 é verdadeira 
{
    Console.WriteLine($"Algumas das 2 é True");
}

if (!booleana3) //o "!" serve para negar logo então é verdadeiro no exemplo
{
    Console.WriteLine("Operador de negação");
}

//Funções e utilização de Função
static void Saudacao(String nome, string nome2) //criação de função e parametros
{
    Console.WriteLine($"{nome} - {nome2}");
}

Saudacao(nome, "Maria"); //utilização da função

//Switch case
string cor = "vermelha";

switch (cor) 
{
    case "azul":
        Console.WriteLine("A cor é azul");
        break;
    case "vermelha":
        Console.WriteLine("A cor é vermelha");
        break;
    default:
        Console.WriteLine("É outra cor");
        break;
}

//Laço de repetição

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($"Numero : {i}");
}

Console.WriteLine("--------------------------------");
int h = 0;
int j = 0;
while (j <= 5) //funciona quando a condicional for True
{
    Console.WriteLine(j);
    j++;
}

do //faz a inicialização do while ao menos uma unica vez
{
    Console.WriteLine("Executado pelo menos uma vez");
    h++;
} while (h < 5);

//Arrays / Foreach

String[] frutas = { "Maça", "Banana", "Laranja" };

Console.WriteLine(frutas[0]);

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

//Orintação a Objetos

Pessoa p = new Pessoa();
p.Nome = "Douglas";
p.idade = 12;
p.Apresentar();