// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void PrintArray(int[] arr) 
// {
//    for (int i = 0; i < arr.Length; i++)
//   {
//       Console.Write($"{arr[i]} ");
//   }
// }
// Console.WriteLine("Введите целое число M- кол-во чисел");
// int M = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[M];

// for (int i = 0; i < M; i++)
// {
//   Console.WriteLine ($"Введите {i+1}е число ");
//   array[i] = Convert.ToInt32(Console.ReadLine());
// }

// PrintArray(array);
// Console.WriteLine();

// int count = 0;
// foreach (int item in array ) 
// {
//     if (item > 0) count++;
// }
// Console.WriteLine ($"Количество чисел больше 0 равно {count}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine ("Введите k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Введите b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Введите k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Введите b2");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Точка 1 - y = k1 * x + b1;
// Точка 2 - y = k2 * x + b2

// k1 * x + b1 = k2 * x + b2

// double x = (b2 - b1)/(k1 - k2);

// k1 * x = b1 - y
// k2 * x = b2 - y

// (b1 - y) / k1 = (b2 - y) / k2
// k1b2 - k1y = k2b1 - k2y
// k1b2 - k2b1 = k1y - k2y
// y(k1 - k2) = k1b2 - k2b2
// double y = (k1*b2 - k2*b1)/ (k1 - k2);

// Console.WriteLine ($"Точка пересечения прямых: ({x};{y})");






// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.

void Tri (double A, double B, double C)
{
if (A < B + C && B < A + C && C < A + B) 
{
    Console.WriteLine ($"Да, {A}, {B} и {C} являются сторонами треугольника.");

    if ( A == B || B == C || C == A) Console.WriteLine ("Это равнобедренный треугольник");

    else if ( A == B && A == C) Console.WriteLine ("Это равносторонний треугольник");

    double P = A + B + C;
    Console.WriteLine ($"Периметр треугольника равен {P}");

    double S = Math.Sqrt (P/2 * (P/2 -A) * (P/2 -B) * (P/2 -C));
    Console.WriteLine ($"Площадь треугольника равна {S}");

    double ugAB = Math.Acos((A*A + B*B - C*C) / (2*A*B)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами А и В равен {ugAB}°");

    double ugCB = Math.Acos((C*C + B*B - A*A) / (2*C*B)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами C и В равен {ugCB}°");

    double ugAC = Math.Acos((A*A + C*C - B*B) / (2*A*C)) * 180 / Math.PI;
    Console.WriteLine ($"Угол между сторонами А и В равен {ugAC}°");

    if (ugAB == 90 || ugCB == 90 || ugAC == 90) Console.WriteLine("Это прямоугольный треугольник");
}
else Console.WriteLine("Это не треугольник");
}
Tri(5 , 1, 1);

// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно один раз переместился на другое место и потом не участвовал никак (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

// void PrintArray(int[,] matr)
// {
//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//  Console.Write($"{matr[i, j]} ");
//  }
//  Console.WriteLine();
//  }
// }
// void FillArray(int[,] matr)
// {
//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//  for (int j = 0; j < matr.GetLength(1); j++)
//  {
//  matr[i,j] = new Random().Next(1,10);//[1; 10)
//  }
//  }
// }
// int[,] matrix = new int[3, 2];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);