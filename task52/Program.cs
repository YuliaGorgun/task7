// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
 
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
 
 
Console.WriteLine("введите номер строки");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер столбца");
int cols = int.Parse(Console.ReadLine()!);
 int [,] array = new int[rows,cols];
FillArrayNumbers(array);
 
for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage +" ; ");
}
Console.WriteLine();
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
