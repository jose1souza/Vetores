using Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Ex4
    {

        static int Nimpar(int[] vetor)
        {   // percorrer o vetor e mostrar o menor
            int cont;
            cont = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    cont++;
                }

            }
            return cont;
        }
        static void Main()
        {
            Console.WriteLine("Escolha o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] meuVetor = new int[n];
            BibliotecaArray.geraVetor(meuVetor);
            Console.WriteLine("O vetor gerado é: ");
            BibliotecaArray.mostraVetor(meuVetor);
            Console.WriteLine($"\n A quantidade de números ímpares no vetor é: {Nimpar(meuVetor)}");
            Console.ReadKey();

        }
    }
}
