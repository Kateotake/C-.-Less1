// Задача HARD SORT.

// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// отсортировать массив из случайных чисел
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j] } ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             array[i, j] = new Random().Next(1, 100);
//     }
//     return array;
// }


// int[,] SortArray(int[,] matr)
// {
//     int min = matr[0, 0];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(0); k++)
//             {
//                 for (int n = 0; n < matr.GetLength(1); n++)
//                 {
//                     if (matr[i, j] < matr[k,n])
//                     {
//                         min = matr[k, n];
//                         matr[k,n] = matr[i, j];
//                         matr[i, j] = min;
//                     }
//                 }
//             }
//         }
//     }
//     return matr;
// }

// int[,] mas = FillArray(3, 4);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(SortArray(mas));




// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// void PrintArray(double[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j] } ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             array[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()),1);
//     }
//     return array;
// }


// double[,] mas = FillArray(3, 4);
// PrintArray(mas);









// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j] } ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FillArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//             array[i, j] = new Random().Next(10, 100);
//     }
//     return array;
// }

// string PrintVal(int [,] matr, int m, int n)
// {
//     if (m > matr.GetLength(0) || n > matr.GetLength(1)) 
//     return $"Элемента на позиции [{m},{n}] нет";
//     else return $"Значение элемента на позиции [{m},{n}] : {matr[m,n]}";
// }

// int[,] mas = FillArray(3, 4);
// PrintArray(mas);
// Console.WriteLine();
// Console.WriteLine(PrintVal(mas,5,5));





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j] } ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 10);
    }
    return array;
}

void AverageColumn(int[,] matr)
{
    double sum = 0;
    double av = 0;
    int j = 0;
    while (j < matr.GetLength(1))
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i, j];
            av = Math.Round((sum / matr.GetLength(0)),2);
        }
        Console.WriteLine($"Среднее арифметическое {j}-го столбца равно {av}");
        j++;
        sum = 0;
    }
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
AverageColumn(mas);

