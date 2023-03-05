// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreaateArray(int m = 2, int n = 3)
{
    int[,] array = new int[m, n];
    return array;
}

void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 5} ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArrayRandom(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}

double[] FindAverage(int[,] arr)
{
    double[] averageArr = new double[arr.GetLength(1)];
    
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double averageNum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            averageNum += (arr[i, j]);
        }
        averageArr[j] = Math.Round(averageNum / arr.GetLength(0), 2); 
    }
    return averageArr;
}

void Main()
{
    int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine();
    Console.WriteLine(string.Join(",   ", FindAverage(arr)));
}

Main();