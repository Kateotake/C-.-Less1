﻿// Двумерные массивы.
//                           стр столб
// string[,]table = new string[2,3]; 
// int[,] matrix = new int [5,8];
string[,] table = new string[2,5]; //столбцов от нуля до 4, строк 2
// String.Empty
// table[0,0]   table[0,1]  table[0,2]  table[0,4]
// table[0,1]   table[1,1]  table[1,2]  table[1,4]

// table[1,2] = "slovo";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console/WriteLine($"-{table[rows,columns]}");
//     }
// }


// вывод и заполнение матрицы 
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // matrix GetLen (0) количество строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //martixGetLen (1) количество столбцов
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillPrintArray (int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // matrix GetLen (0) количество строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) //martixGetLen (1) количество столбцов
//         {
//             matr[i,j] = new Random ().Next (1,10);
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int [,] matrix = new int [3,4];

// PrintArray(matrix);
// Console.WriteLine();
// FillPrintArray(matrix);


// метод вывода рисунка
// void PrintImage (int[,] image)
// {
//      for (int i = 0; i < image.GetLength(0); i++) 
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//            if (image[i,j] == 0) Console.Write($" ");
//            else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] pic = new int[,] // можно задать матрицу
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// //метод закрашивания чб изображения
// void FillImage (int row, int col)

// {
//     if (pic[row, col] == 0) // не закрашен 
//     {
//         pic[row,col] = 1;
//         // РЕКУРСИЯ - это метод которая вызывает сам себя
//         FillImage(row - 1,col); //вверх
//         FillImage(row,col - 1); //влево
//         FillImage(row + 1,col); //вниз
//         FillImage(row,col + 1); //вправо
//     }
// }


// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);



// расчет факториала с помощью рекурсии

// double Factorial (int n)
// {
//     // 1! = 1
//     // 0! = 1 - частный случай
//     if (n == 1) return 1;
//     else return n * Factorial(n-1); 
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// Фибоначчи - каждое следующее число задается с помощью предыдущего
// 1 1 2 3 5 8 13 21
// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

// int Fibonacci(int n)
// {
//     if ( n== 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine ($"f({i}) = {Fibonacci(i)}");
// }
