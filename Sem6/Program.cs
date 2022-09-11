// void FillPrintArray(int[] arr) 
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random ().Next(-100,100);
//         Console.Write(arr[i] + " ");
//     }
//     Console.Write(arr[arr.Length - 1] + "] ");
// }

// переворачиваем массив

// void FillArray(int[] arr) 
// {
//     for (int i = 0; i < arr.Length ; i++)
//     {
//         arr[i] = new Random ().Next(-100,100);
//     }
// }
// void PrintArray(int[] arr) 
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length -1; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "] ");
// }
  
// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];

// FillArray(array);
// PrintArray(array);

// void ChangeArray(int[] arr)
// {
//     int buf;
//     for (int i = 0; i < N/2; i++)
//     {
//         buf = array[i];
//         array[i] = array[N-1-i];
//         array[N-1-i] = buf;
//     }
// }

// Console.WriteLine();
// ChangeArray(array);
// PrintArray(array);




// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
// string CheckTr()
// {
//     string res = "";
//     Console.WriteLine("A");
//     int A = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("B");
//     int B = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("C");
//     int C = Convert.ToInt32(Console.ReadLine());

//     if (A < B + C && B < A + C && C < A + B) res = "Yes";
//     else res = "No";
//     return res;
// }
// Console.WriteLine(CheckTr());



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите десятичное число ");
// int N = Convert.ToInt32(Console.ReadLine());
// while (N != 0)
// {
//     int N1 = N % 2;
//     N = N/2;
//     Console.Write (N1);
// }
// +перевернуть


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



// void PrintArray(int[] arr) 
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length -1; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "] ");
// }
  
// Console.WriteLine("Введите целое число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];
// array[0]=0;
// array[1]=1;
// for (int i = 2; i < N; i++)
// {
//     array[i] = array[i-1] + array[i-2];
// }

// PrintArray(array);



//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.