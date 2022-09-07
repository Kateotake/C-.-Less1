// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillPrintArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random ().Next(100,1000); 
//         Console.Write($"{arr[i]} ");
//     }
// }

// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];

// FillPrintArray(array);
// Console.WriteLine();

// int count = 0;

// foreach (int item in array ) 
// {
//     if (item % 2 == 0) count++;
// }
// Console.WriteLine ($"Количество четных элементов равно {count}");




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillPrintArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random ().Next(-100,100); 
//         Console.Write($"{arr[i]} ");
//     }
// }

// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];

// FillPrintArray(array);
// Console.WriteLine();

// int sum = 0;

// for (int i = 0; i < array.Length; i++ ) 
// {
//     if (i % 2 == 1) 
//     sum = sum + array[i];
// }
// Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях, равна {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void FillPrintArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random ().Next(-100,100); 
//         Console.Write($"{arr[i]} ");
//     }
// }
// void MinMax(int[] arr3) // метод нахождения минимума и максимума
// {
//     int i = 0;
//     int j = 0;
//     int maxPos = 0;
//     int minPos = 0; 
//     while ( i < arr3.Length)  
//     {
//         if (arr3[i] < arr3[minPos]) minPos = i;
//         i++;
//     }
//       Console.WriteLine($"Минимальное значение массива : {arr3[minPos]}");
        
//     while (j < arr3.Length)
//     {
//         if (arr3[j] > arr3[maxPos]) maxPos = j;
//         j++;
//     }
//      Console.WriteLine($"Максимальное значение массива : {arr3[maxPos]}");
//      Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {arr3[maxPos] - arr3[minPos]}");
// }

// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];

// FillPrintArray(array);
// Console.WriteLine();
// MinMax(array);





// Задача 19 HARD - необязательная
// Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.

//надо переdернуть число и сравнить. если оно равно то палиндром

// Console.WriteLine("Введите число");
          
// string N = Console.ReadLine();
// string N1 = string.Empty;
// for (int i = N.Length - 1; i > -1; --i)
// {
//     N1 = N1 + N[i];
// }

// if (N == N1) Console.WriteLine ($" Число {N} является палиндромом");
// else Console.WriteLine ($" Число {N} не является палиндромом");




// Задача 21 HARD - необязательная
// Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. 
//N - задается пользователем.

// void PrintArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array_x = new int[N];
// int [] array_y = new int[N];
// Console.WriteLine ("Введите координаты точки Х:");
// for (int i = 0; i < N; i++)
// {
//     array_x[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine ("Введите координаты точки Y:");
// for (int j = 0; j < N; j++)
// {
//     array_y[j] = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write("Координаты точки Х : ");
// PrintArray(array_x);
// Console.Write("Координаты точки Y : ");
// PrintArray(array_y);

// double sum = 0;
// for (int i = 0; i < N; i++)
// {
//     sum += (array_x[i] - array_y[i]) * (array_x[i] - array_y[i]);
// }

// double res = Math.Sqrt(sum);
// Console.WriteLine ($"Расстояние между точками X и Y равно {res} ");



void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double DlinaOtrezka (int N)
{
    int [] array_x = new int[N];
    int [] array_y = new int[N];
    Console.WriteLine ("Введите координаты точки Х:");
    for (int i = 0; i < N; i++)
    {
        array_x[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine ("Введите координаты точки Y:");
    for (int j = 0; j < N; j++)
    {
        array_y[j] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Координаты точки Х : ");
    PrintArray(array_x);
    Console.Write("Координаты точки Y : ");
    PrintArray(array_y);

    double sum = 0;
    for (int i = 0; i < N; i++)
    {
        sum += (array_x[i] - array_y[i]) * (array_x[i] - array_y[i]);
    }

    double result = Math.Sqrt(sum);
    return result;
}
double res = DlinaOtrezka(4);
Console.WriteLine ($"Расстояние между точками X и Y равно {res} ");
