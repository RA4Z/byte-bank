Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
//TestaMediana(amostra);

//TestaArrayInt();
//TestaBuscarPalavra();

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

void TestaMediana(Array array)
{
    if(array == null || array.Length == 0)
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo!");
    }
    double[] numerosOrdenados = (double [])array!.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho%2!=0)? numerosOrdenados[meio] 
        : (numerosOrdenados[meio]+ numerosOrdenados[meio-1]) /2;
    Console.WriteLine($"Com base na amostra o valor do meio é igual a => {mediana}");
}

int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine(valores[i]);
}