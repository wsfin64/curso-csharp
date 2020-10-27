using System;

// GO TO - Direcionar a execução do programa para um ponto pré determinado
class Aula16 {

    static void Main() {

        int tempo = 0;
        char escolha;

        inicio:  // Label determinar um ponto onde será redirecionado a execução do programa.
        Console.Clear();  // Limpar o console

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

        Console.Write("\nCalcular outro transporte? [s/n]: ");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 'S' | escolha == 's') {
            goto inicio;  // Neste caso, retornará para o início do código
        } else {
            Console.Clear();
            Console.WriteLine("Fim do programa!");
        }

    }
}