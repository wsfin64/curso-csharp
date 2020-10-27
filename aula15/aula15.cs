using System;

// SWITCH CASE
class Aula15 {

    static void Main() {
        int tempo = 0;
        char escolha;
        Console.WriteLine("Belo Horizonte-MG à Vitória-ES");
        Console.WriteLine("Escolha o transporte: [a]-Avião | [c]-Carro | [o]-Ônibus ");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                break;
            
            case 'c':
            case 'C':
                tempo = 480;
                break;

            case 'o':
            case 'O':
                tempo = 660;
                break;

            default:
                tempo = -1;
                break;

        }

        if (tempo < 0) {
            Console.WriteLine("Transporte indisponível");

        } else {
            Console.WriteLine("O tempo para o transporte escolhido é {0} minutos", tempo);
        }

    }
}