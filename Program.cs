// Faça um programa que implemente o meme Fluxograma da Engenharia.
// O objeto está se movendo (S/N)? N. Deveria? S! Use WD-40.
// O objeto está se movendo? (S/N) N. Deveria? N! Ótimo.
// O objeto está se movendo? (S/N) S. Deveria? N! Use Silver tape.
// O objeto está se movendo? (S/N) S. Deveria? S! Ótimo.

Console.Clear();
Console.WriteLine("Fluxograma da Engenharia 🛠️\n");

Console.Write("O objeto está se movendo? (S/N) ");
string respostaMovendo = Console.ReadLine()!.Trim().ToUpper();

if (respostaMovendo != "S" && respostaMovendo != "N")
{
    Console.WriteLine("Resposta inválida. Use apenas S ou N.");
    return;
}

Console.Write("Deveria? (S/N) ");
string respostaDeveria = Console.ReadLine()!.Trim().ToUpper();

if (respostaDeveria != "S" && respostaDeveria != "N")
{
    Console.WriteLine("Resposta inválida. Use apenas S ou N.");
    return;
}

if (respostaMovendo == "S" && respostaDeveria == "N")
{
    Console.WriteLine();
    Console.WriteLine("Use Silver tape.");
}
else if (respostaMovendo == "N" && respostaDeveria == "S")
{
    Console.WriteLine();
    Console.WriteLine("Use WD-40.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Ótimo.");
}