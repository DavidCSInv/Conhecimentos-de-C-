using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digte o numero de linhas e colunas :");

        string[] vet = Console.ReadLine().Split(' ');
        int M = Convert.ToInt32(vet[0]);
        int N = Convert.ToInt32(vet[1]);

        int[,] matriz = new int[M, N];

        for (int i = 0; i < M; i++)
        {
            string[] valores_matriz = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                matriz[i, j] = int.Parse(valores_matriz[j]);
            }
        }

        int numero_escolhido = Convert.ToInt32(Console.ReadLine());


        //for (int i = 0; i < 1; i++)
        //{
        //    for (int j = 0; j < N; j++)
        //    {
        //        if (numero_escolhido == matriz[i, j])
        //        {
        //            Console.WriteLine("Left: " + matriz[0, 0]);
        //            Console.WriteLine("Right: " + matriz[0, 2]);
        //            Console.WriteLine("Down: " + matriz[1, 1]);
        //        }
        //    }
        //}

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (numero_escolhido == matriz[i, j])
                {
                    Console.WriteLine("Position " + i + "," + j + ":");
                    if (j > 0)
                    {
                        Console.WriteLine("Left: " + matriz[i, j - 1]);
                    }
                    if (i > 0)
                    {
                        Console.WriteLine("Up: " + matriz[i - 1, j]);
                    }
                    if (j < N - 1)
                    {
                        Console.WriteLine("Right: " + matriz[i, j + 1]);
                    }
                    if (i < M - 1)
                    {
                        Console.WriteLine("Down: " + matriz[i + 1, j]);
                    }
                }
            }
            //}for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (numero_escolhido == matriz[i, j])
            //        {
            //            Console.WriteLine(matriz[0,0]);
            //            Console.WriteLine(matriz[0,2]);
            //            Console.WriteLine(matriz[1,1]);
            //        }
            //    }
            //}

            //Console.WriteLine("Linhas e colunas");

            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        Console.Write(matriz[i, j]);
            //    }
            //}
        }
    }
}
