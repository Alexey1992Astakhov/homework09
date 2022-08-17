//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    OrderArrayLines(array);
    PrintArray(array);
}
void FillArray(int [,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0;j < columns; j++)
        {
            array [i, j] = random.Next(startNumber, finishNumber);
        }
    }
}
void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0;j < columns; j++)
        {
            Console.Write(array [i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}
Console.WriteLine($"\n Начальный массив: ");
void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  Console.WriteLine($"\nОтсортированный массив: ");
}
Zadacha54();



