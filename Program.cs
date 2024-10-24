
// Lendo string e garantindo que variável não ficara nula
Console.WriteLine("Escreva uma string: ");
string stringTeste = Console.ReadLine() ?? "";

// Inicializando contador de frequência
int frequenciaA = 0;

// Varrer cada caracter da string
foreach (char caracter in stringTeste) {

    // Se sua versão maiúscula for igual a 'A', contabilizar 1 ocorrência da letra A
    if (char.ToUpper(caracter) == 'A')
        frequenciaA++;
}

// Imprimindo resultado
if (frequenciaA > 0)
    Console.WriteLine("A letra A aparece {0} vezes na string informada.", frequenciaA);
else
    Console.WriteLine("A letra A não aparece na string informada.");