using System;

class Aula09 {

    // OPERAÇÕES DE BITWISE/SHIFT
    static void Main() {

        // Deslocamento de bits para a esquerda << dobre o valor
        // Deslocamento de bits para a direira >> diminui pela metade

        int num = 10;
        num = num >> 1;
        Console.WriteLine(num);
    }
}