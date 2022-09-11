// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// try{   //попытаться сделать это:
//     Console.Write ("введите координату х ");
//     int x = int.Parse (Console.ReadLine());
//     Console.Write ("введите координату y ");
//     int y = int.Parse (Console.ReadLine());

//     int res;
//     if (x > 0 && y > 0) res = 1;
//     else if (x > 0 && y < 0) res = 2;
//     else if (x < 0 && y < 0) res = 3;
//     else if (x < 0 && y > 0) res = 3;
//     else res = 0;

//     if ( res != 0) Console.WriteLine($"это четверть с номером {res}");
//     else Console.WriteLine("точка лежит на осях");
// }
// catch // а если не получится, то "поймать"
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }

// с функцией

// string GetNum4()
// {
//     Console.Write ("введите координату х ");
//     int x = int.Parse (Console.ReadLine());
//     Console.Write ("введите координату y ");
//     int y = int.Parse (Console.ReadLine());

//     int res;
//     if (x > 0 && y > 0) res = 1;
//     else if (x > 0 && y < 0) res = 2;
//     else if (x < 0 && y < 0) res = 3;
//     else if (x < 0 && y > 0) res = 4;
//     else res = 0;

//     if ( res != 0) return($"это четверть с номером {res}"); // != не равно
//     else return("точка лежит на осях");
// }
// try
// { 
//    Console.WriteLine (GetNum4());
// }
// catch // а если не получится, то "поймать"
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }

//_____________________________________________________________________________________________________________

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string GetNum4()
// {
//     Console.Write ("Введите номер четверти ");
//     int k = int.Parse (Console.ReadLine());
  
//     if ( k == 1)  return ("x > 0  y > 0");
//     else if  (k == 2) return ("x > 0  y < 0");
//     else if  (k == 3) return ("x < 0  y < 0");
//     else if  (k == 4) return ("x < 0  y > 0");

//     else return("такой четверти нет");
// }
// try
// { 
//    Console.WriteLine (GetNum4());
// }
// catch // а если не получится, то "поймать"
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }


// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//  string GetNum4()
// {
//     Console.Write ("введите координату x Точки А ");
//     double x1 = Convert.ToDouble (Console.ReadLine());
//     Console.Write ("введите координату y Точки А ");
//     double y1 = Convert.ToDouble (Console.ReadLine());
//     Console.Write ("введите координату x Точки B ");
//     double x2 = Convert.ToDouble (Console.ReadLine());
//     Console.Write ("введите координату y Точки В ");
//     double y2 = Convert.ToDouble (Console.ReadLine());

//     double res = Math.Sqrt (Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));

//     return $"{res}";
// }
// try
// { 
//    Console.WriteLine (GetNum4());
// }
// catch // а если не получится, то "поймать"
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }



// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// string GetNum4()
// {
//     Console.Write ("введите целое число N ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int k = 1;
//     string res = string.Empty;

//     while (k <= N)
//     {  
//         res = res + k*k + ", ";
//         k++;
//     }
// return res;
// }    
// try
// { 
//    Console.WriteLine (GetNum4());
// }
// catch 
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }

// без функции
//  Console.Write ("введите целое число N ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int k = 0;
//      while (k <= N)
//     {  
//          int res = k*k*k;
//          Console.Write ($"{res}, ");
//          k++;
//     }     


// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//  Console.Write ("введите пятизначное число N: ");
//     string N = Console.ReadLine();
//     int dlina = N.Length;
//     int K = Convert.ToInt32 (N);
//     int n1 = K/10000;
//     int n2 = (K/1000) % 10;
//     int n4 = (K/10) % 10;
//     int n5 = K % 10;

// if (dlina == 5)
// {
//     if ((n1 == n5) && (n2 == n4)) Console.WriteLine("Да");
//     else Console.WriteLine ("Нет");
// }
// else Console.WriteLine ("Нужно пятизначное число");



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

    // Console.Write ("введите координату x Точки А ");
    // double x1 = Convert.ToDouble (Console.ReadLine());
    // Console.Write ("введите координату y Точки А ");
    // double y1 = Convert.ToDouble (Console.ReadLine());
    // Console.Write ("введите координату z Точки А ");
    // double z1 = Convert.ToDouble (Console.ReadLine());
    // Console.Write ("введите координату x Точки B ");
    // double x2 = Convert.ToDouble (Console.ReadLine());
    // Console.Write ("введите координату y Точки В ");
    // double y2 = Convert.ToDouble (Console.ReadLine());
    // Console.Write ("введите координату z Точки B ");
    // double z2 = Convert.ToDouble (Console.ReadLine());

    // double res = Math.Sqrt (Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));

    // Console.WriteLine(res);

// try
// { 
//    Console.WriteLine (GetNum4());
// }
// catch // а если не получится, то "поймать"
// {
//     Console.WriteLine ("Надо было написать именно целые числа");
// }





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//  Console.Write ("введите целое число N ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     int k = 0;
//      while (k <= N)
//     {  
//          int res = k*k*k;
//          Console.Write ($"{res}, ");
//          k++;
//     }     


// задача необязательная

// Напишите программу, которая считывает с консоли числа (по одному в строке) 
//до тех пор, пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
// Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.

// В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, 
//что сумма этих чисел равна нулю и выводим сумму их квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.﻿

// На входе:
// 1
// -3
// 5
// -6
// -10
// 13
// 4
// -8

// На выходе:

// 340


int sum = 0;
int sqr = 0;
while (true)
{
    int N = Convert.ToInt32(Console.ReadLine());
    sum = sum + N;
    sqr = sqr + N*N;
  
if (sum ==0) break;
}
//  while (Console.ReadKey().Key != ConsoleKey.Escape) {
//         }
Console.WriteLine (sqr);