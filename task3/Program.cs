// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] a = new int [2, 2] { {2, 4}, {3, 2} };
int[,] b = new int [2, 2] { {3, 4}, {3, 3} };
int[,] ab = new int[a.GetLength(0), b.GetLength(1)];

for (int i = 0; i < ab.GetLength(0); i++)
{
    for (int j = 0; j < ab.GetLength(1); j++)
    {
        int sum = 0;
        for (int x = 0; x < a.GetLength(1); x++)
        {
            sum += a[i, x] * b[x, j];
        }
        ab[i, j] = sum;
    }
}

Console.Write($"Произведение двух матриц: \n");

for (int i = 0; i < ab.GetLength(0); i++)
{
    for (int j = 0; j < ab.GetLength(1); j++)
    {
        Console.Write($"{ab[i, j]} ");
    }
    Console.Write($"\n");
}