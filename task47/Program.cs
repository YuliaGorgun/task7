// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
 
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.WriteLine("введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов");
int cols = int.Parse(Console.ReadLine()!);
double [,] array = new double[rows,cols];
FillArrayRandomNumbers(array);
PrintArray(array);
 
double [,] FillArrayRandomNumbers( double [,] array )
{
    double[,] numbers = new double[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =Convert.ToDouble(new Random().Next(0, 100))/10;
        }
    }
    return array;
}
 
void PrintArray(double[,] array)
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

