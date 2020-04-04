using System;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Insira os dados da Primeira Pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n- Dados das pessoas -\nPrimeira Pessoa:\nNome - {p1.Nome}\nIdade - {p1.Idade}\nSegunda Pessoa:\nNome - {p2.Nome}\nIdade - {p2.Idade}");
        }
    }
}