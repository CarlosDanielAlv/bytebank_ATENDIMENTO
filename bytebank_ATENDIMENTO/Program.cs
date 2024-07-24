Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");



void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 50;
    idades[3] = 60;
    idades[4] = 70;

    Console.WriteLine($"Tamanho do array {idades.Length}");

    int acumulador = 0;
    foreach (int i in idades)
    {
        Console.WriteLine(i);
        acumulador += i;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média =  {media}");
}

TestaArrayInt();
