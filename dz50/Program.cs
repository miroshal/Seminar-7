// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] CreaateArray(int m = 5, int n = 5)
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
            System.Console.Write($"{array[i, j], 4}  ");
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

string FindNumber(int[,] arr)
{
    int findNum = Prompt("Какое число будем искать?: ");
    string result = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] == findNum)
            {
                result = result + $" {findNum} на позиции [{i}, {j}]\n";
            } 
        }
    }
    return result == "" ? $"Числа {findNum} нет" : result;
}

void Main()
{
    int[,] arr = CreaateArray();
    arr = FillArrayRandom(arr);
    PrintArr(arr);
    System.Console.WriteLine(FindNumber(arr));
}

Main();