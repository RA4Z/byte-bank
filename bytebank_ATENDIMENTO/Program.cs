Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
TestaArrayInt();

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