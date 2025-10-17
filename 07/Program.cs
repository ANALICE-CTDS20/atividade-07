
// Solicita os números inicial e final ao usuário
using System.ComponentModel;

Console.Write("Digite o número inicial da tabuada: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Digite o número final da tabuada: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine(); // Espaço

// Loop externo para o intervalo
for (int num = start; num <= end; num++)
{
    Console.WriteLine($"Tabuada do {num}:");
    Console.WriteLine(new string('-', 20));

    // Loop interno de 1 a 10
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{num} x {i} = {num * i}");
    }

    Console.WriteLine(); // Espaço entre tabuadas
}

Console.WriteLine("Tabuadas concluídas. Pressione qualquer tecla para sair...");
Console.ReadKey();
        




