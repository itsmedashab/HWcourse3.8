// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m, n;
Console.Write($"Введите количество строк в массиве: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write($"Введите количество столбцов в массиве: ");
int.TryParse(Console.ReadLine()!, out n);

int[,] array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         array[i,j] = new Random().Next(10);
         Console.Write($"{array[i, j]} ");
    }
    Console.Write($"\n");
}
Console.Write($"\n");

 SelectionSort(array);
 PrintArray(array);
 
//-----------------------------------
 void SelectionSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int a = j + 1; a < arr.GetLength(1); a++)
            {
                if (arr[i, a] > arr[i, maxPosition]) maxPosition = a;
            }
            (arr[i, j], arr[i, maxPosition]) = (arr[i, maxPosition], arr[i,j]);
        }
    }
}

//------------------------------
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write($"\n");
    }
    Console.Write($"\n");
}