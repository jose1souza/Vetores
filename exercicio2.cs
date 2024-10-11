using Arrays;
using System;

class exercicio2
{
    static double maiorVetor(double[] vetor)
    {   // percorrer o vetor e mostrar o maior
        double maior = vetor[0];
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }
    static void Main()
    {
        Console.WriteLine("Tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());
        double[] meuVetor = new double[n];
        BibliotecaArray.geraVetor(meuVetor);
        Console.WriteLine("Vetor gerado: ");
        BibliotecaArray.mostraVetor(meuVetor);
        Console.WriteLine($"\n O maior número do vetor é igual a: {maiorVetor(meuVetor):F2}");
        Console.ReadKey();

    }
}