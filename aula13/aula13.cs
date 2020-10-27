using System;

class Aula13 {

    static void Main() {

        double n1, n2, n3, n4;
        n1 = n2 = n3 = n4 = 0;

        double media = 0;

        string resultado;

        Console.Write("Informe o n1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Informe o n2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Informe o n3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Informe o n4: ");
        n4 = double.Parse(Console.ReadLine());

        media = (n1 + n2 + n3 + n4) / 4;

        if (media >= 70) {

            resultado = "Aprovado";

        } else if (media > 40 & media < 69) {
            resultado = "Final";
        
        } else {
            resultado = "Reprovado";
        }

        Console.WriteLine("Média: {0} - Situação: {1}", media, resultado);

    }
}