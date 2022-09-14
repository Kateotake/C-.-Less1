// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

// int[,] SortArrayRow(int[,] matr)
// {
//     int min = matr[0,0];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         { 
//             for (int k = 0; k < matr.GetLength(1); k++)
//             {
//                 if (matr[i, j] < matr[i,k])
//                 {
//                     min = matr[i, k];
//                     matr[i,k] = matr[i, j];
//                     matr[i, j] = min; 
//                 }
//             }
//         }
//     }
//     return matr;
// }

// int[,] mas = FillArray(3, 4);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(SortArrayRow(mas));




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// void RowsSum(int[,] matr)
// {
//     int minsum = 0;
//     int min = 0;

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matr.GetLength(1); j++)
//         { 
//             sum = sum +matr[i,j];
//         }
//         Console.WriteLine ($"Cумма элементов {i}й строки равна {sum}");
//         if (i == 0 || sum < minsum) 
//             {
//                 minsum = sum;
//                 min = i;
//             }
//     }
//      Console.WriteLine ($"Номер строки с минимальной суммой элементов : {min}");
// }

// int[,] mas = FillArray(4, 3);
// PrintArray(mas);
// Console.WriteLine();
// RowsSum(mas);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] FillSpiralArray(int m, int l)
// {
//     int[,] a = new int[m, l];

//     int row = m - 1;
//     int col = l - 1;
//     int n = 0;
//     int i = 0;
//     int j = 0;
//     int k = 1;

//     while (n != m *l)
//     {
//         for (j = n; j <= col - n; j++)
//         {
//             i = n;
//             a[i, j] = k;
//             k++;
//         }
    
//         for (i = n + 1; i <= row - n; i++)
//         {
//             j = col - n;
//             a[i, j] = k;
//             k++;
//         }
    
//         for (j = col - n - 1; j >= n; j--)
//         {
//             i = row - n;
//             a[i, j] = k;
//             k++;
//         }
    
//         for (i = row - n - 1; i >= n + 1; i--)
//         {
//             j = n;
//             a[i, j] = k;
//             k++;
//         }

//         n++;
//     } 

//     return a;
// }

// int[,] mas = FillSpiralArray(7, 7);
// PrintArray(mas);
 











// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


void PrintArray(int[,,] matr)
{
    for (int col = 0; col < matr.GetLength(2); col++)
    {
        for (int list = 0; list < matr.GetLength(1); list++)
        {
            for (int row = 0; row < matr.GetLength(0); row++)
            {
            Console.Write($"{matr[list, row, col]} ({list},{row} {col}) " );
            }
        Console.WriteLine();
        };
    }
}

int[,,] FillArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                array[i, j, k] = new Random().Next(1, 100);
            }
        }
    } 
    return array;
}


int[,,] mas = FillArray(2, 2, 2 );
PrintArray(mas);
