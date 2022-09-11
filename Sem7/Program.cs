// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // void FillArray(int[,] matr)
// // {
// //     for (int i = 0; i < matr.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matr.GetLength(1); j++)
// //         {
// //             matr[i,j] = new Random().Next(1,10);//[1; 10)
// //         }
// //     }
// // }

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
// Console.Write("Введите количество строк двумерного массива ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов двумерного массива ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] mas = FillArray(m,n);


// PrintArray(mas);



//__________________________________________________________________
// Задача 48: Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
// Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса нечётные, и 
//замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
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
//             array[i, j] = i + j;
//     }
//     return array;
// }

// int[,] FillNewArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i%2 == 1 && j%2 == 1) 
//                 matr[i,j] = matr[i,j] * matr[i,j];
//         }
//     }
//     return matr;
// }

// int[,] mas = FillArray(3,4);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(FillNewArray(mas));

// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
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
//             array[i, j] = new Random().Next(1,10);
//     }
//     return array;
// }

// int[,] FillNewArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i%2 == 0 && j%2 == 0) 
//                 matr[i,j] = matr[i,j] * matr[i,j];
//         }
//     }
//     return matr;
// }

// int SumMainDiag(int[,] matr)
// {
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j) 
//                 sum = sum + matr[i,j];
//         }
//     }
//     return sum;

// }
// int[,] mas = FillArray(3,4);
// PrintArray(mas);
// Console.WriteLine("Массив после изменения:");
// PrintArray(FillNewArray(mas));
// Console.WriteLine();

// Console.WriteLine($"Сумма элементов главной диагонали равна {SumMainDiag(mas)}");

// Задача HARD SORT.

// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

// отсортировать массив из случайных чисел
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
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}


int[,] SortArray(int[,] matr)
{
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int n = 0; n < matr.GetLength(1); n++)
                {
                    if (matr[i, j] < matr[k,n])
                    {
                        min = matr[k, n];
                        matr[k,n] = matr[i, j];
                        matr[i, j] = min;
                    }
                }
            }
        }
    }
    return matr;
}

int[,] mas = FillArray(3, 4);
PrintArray(mas);
Console.WriteLine();
PrintArray(SortArray(mas));



