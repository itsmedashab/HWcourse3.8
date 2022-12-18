// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int sumMin = n * 10;
int sumCount = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    if (sum < sumMin)
    {
        sumMin = sum;
        sumCount = i;
    }
}
Console.Write($"Наименьшую сумму элементов имеет строка с индексом = {sumCount}\n");