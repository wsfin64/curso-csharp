using System;

class Aula12 {

    // Condicional IF
    static void Main() {

        double nota = 0;
        string resultado = "Reprovado";

        Console.Write("Informe a nota: ");
        nota = double.Parse(Console.ReadLine());


        if (nota >= 60) {
            resultado = "Aprovado";
        }
        Console.WriteLine("Situação: {0}", resultado);

    }

}