using System;

//ENUMERADORES (enum)
class Aula10 {

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};  // Únicos valores possíveis para a "classe" DiasSemana
    static void Main() {
        
        DiasSemana ds = (DiasSemana)2;  // Convertendo o valor inteiro para DiasSemana
        // DiasSemana ds = DiasSemana.Domingo;

        int dia = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);

    }
}