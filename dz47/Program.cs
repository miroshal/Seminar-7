// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[,] CreaateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 5}  ");
        }
        System.Console.WriteLine();
    }
}

double[,] FillArrayRandom(double[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return coll;
}

void Main()
{
    double[,] arr = CreaateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
    arr = FillArrayRandom(arr);
    Console.WriteLine();
    PrintArr(arr);
}

Main();