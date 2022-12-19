// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int[,,] array = new int[2, 2, 2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
         for (int x = 0; x < array.GetLength(2); x++)
         {
            array[i, j, x] = new Random().Next(10, 100);
            Console.Write($"{array[i, j, x]}({i}, {j}, {x}) ");
         }
         Console.Write($"\n");
    }
    Console.Write($"\n");
}