// Задача 53: Задайте двумерный массив. 
//Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

// int[,] ChangeRows(int[,] matr)
// {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         { 
//             int temp = matr[0,j];
//             matr[0,j] = matr[matr.GetLength(0)-1,j];
//             matr[matr.GetLength(0)-1,j] = temp;
//         }
    
//     return matr;

// }

// int[,] mas = FillArray(4, 3);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(ChangeRows(mas));



// Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.

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

// int[,] ChangeRowsColumns(int[,] matr)
// {
//     int row = matr.GetLength(0);
//     int col = matr.GetLength(1);

//     int [,] matr2 = new int[col,row];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         { 
//             matr2[i,j] = matr[j,i];
//         }
//     }
//     return matr2;

// }

// int[,] mas = FillArray(4, 4);
// PrintArray(mas);
// Console.WriteLine();
// PrintArray(ChangeRowsColumns(mas));
// else Console.WriteLine("Такую матрицу нельзя повернуть");



// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается 
//элемент входных данных.

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

void RowsSum(int[,] matr)
{
    int minsum = 0;
    int min = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        { 
            sum = sum +matr[i,j];
        }
        Console.WriteLine ($"Cумма элементов {i}й строки равна {sum}");
        if (i == 0 || sum < minsum) 
            {
                minsum = sum;
                min = i;
            }
    }
     Console.WriteLine ($"Номер строки с минимальной суммой элементов : {min}");
}

int[,] mas = FillArray(4, 3);
PrintArray(mas);
Console.WriteLine();
RowsSum(mas);