//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
 
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
 
Console.WriteLine("введите номер строки");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер столбца");
int cols = int.Parse(Console.ReadLine()!);
 int [,] array = new int[5,5];
FillArrayNumbers(array);
 
if (rows > array.GetLength(0) || cols > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {rows}-й строки и {cols}-го столбца равно {array[rows-1,cols-1]}");
}
 
PrintArray(array);
 
void FillArrayNumbers(int[,] array, int minValue = 0, int maxValue = 10)
{
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = rnd.Next(minValue, maxValue + 1);
            }  
        }
}
 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }  
       
        Console.WriteLine("");
    }
}

