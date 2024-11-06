//Utilizando Matrizes:
//Problema "diagonal_negativos"
//Fazer um programa para ler um número inteiro N (máximo = 10) e uma matriz quadrada de ordem N
//contendo números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores negativos da matriz. 

namespace DiagonalNegativosMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, quantNegativos = 0;
            string diagonalPrincipal = "";

            Console.Write("Qual a ordem da matriz? ");
            n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento[{i},{j}]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                diagonalPrincipal += (mat[i, i] + " ");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        quantNegativos++;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"DIAGONAL PRINCIPAL: {diagonalPrincipal}");
            Console.WriteLine($"QUANTIDADE DE NEGATIVOS = {quantNegativos}");
        }
    }
}
