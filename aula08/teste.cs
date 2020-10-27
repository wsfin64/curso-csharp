using System;

class Teste {

    static void Main() {
        string nome, profissao;

        int idade;

        Console.Write("Informe o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe a sua profissão: ");
        profissao = Console.ReadLine();

        Console.Write("Informe a sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Obrigado pelas informações {0}, então você trabalha como {1} e tem {2} anos de idade, certo?", nome, profissao, idade);
    }
}