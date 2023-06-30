Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
TestaArrayInt();
TestaBuscarPalavra();

void TestaArrayInt()
{
    Random idade = new Random();
    int[] idades = new int[5];
    for (int i = 0; i < idades.Length; i++)
    {
        idades[i] = idade.Next(80); //Função para buscar números aleatórios
    }
    Console.WriteLine($"Tamanho do Array {idades.Length}\n");
    ListarIdades(idades);
}

void ListarIdades(int[] idades)
{
    int somaIdades = 0;
    for(int i = 0;i < idades.Length;i++)
    {
        Console.WriteLine($"Idade {i+1} => {idades[i]}");
        somaIdades += idades[i];
    }
    Console.WriteLine($"\nSoma de todas as idades no Array => {somaIdades}");
}

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for(int i = 0; i < arrayDePalavras.Length ; i++)
    {
        Console.WriteLine($"Digite a palavra do índice {i+1} => ");
        arrayDePalavras[i] = Console.ReadLine()!;
    }
    Console.WriteLine("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if(palavra.Equals(busca))
        {
            Console.WriteLine($"A palavra {palavra} foi encontrada no Array!");
            return;
        }
    }
    Console.WriteLine($"A palavra {busca} não foi encontrada no Array!");
}