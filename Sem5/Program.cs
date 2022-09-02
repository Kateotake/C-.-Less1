
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] FillArray(int size) //метод заполнения массива
// {
//     int [] array = new int [size];
//     for (int i = 0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-9,10);
//         if (i != array.Length - 1) Console.Write ($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}");
//     }
//     return array;
// }

// int[] mas = FillArray(5);

// int[] FindSums(int[] array)
// {
//     int sum_p = 0;
//     int sum_n = 0;
//     foreach (int item in array ) //работает для объявленных или созданных массивов по очереди перебирает ЗНАЧЕНИЯ - сначала item = a[0] потом a[1] и тд (тип переменных совпадает с переменными массива)
//     {
//         if (item > 0) sum_p += item;
//         else sum_n += item;
//     }
//     int[] arr1 = {sum_n, sum_p};//скобочки фигурные
//     return arr1;
// }

// int [] result = FindSums(mas);
// Console.WriteLine($" Сумма отрицательных чисел равна {result[0]}");
// Console.WriteLine($" Сумма положительных чисел равна {result[1]}");



// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// void FillArray(int[] arr) //метод заполнения массива

// {
//     int length = arr.Length;
//     int index = 0;
//     while (index < length)
//     {
//         arr[index] = new Random ().Next(-100,100); // рандом - целое рандомное число по порядку от 1 до 10
//         index++;
//     }
// }

// void PrintArray(int[] arr2) // метод вывода массива на экран
// {
//     int length2 = arr2.Length;
//     int index2 = 0;
//     while (index2 < length2)
//     {
//         Console.Write($"{arr2[index2]} ");
//         index2++;
//     }
// }    

// void Selection(int[] arr3) 
// {
//     for (int i = 0; i < arr3.Length ; i++) 
//     {
//         arr3[i] = arr3[i] * -1;
//     }
// }

// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [] array = new int[N];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine();
// Selection(array);
// PrintArray(array);




// Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void FillArray(int[] arr) //метод заполнения массива

// {
//     int length = arr.Length;
//     int index = 0;
//     while (index < length)
//     {
//         arr[index] = new Random ().Next(-10,10); // рандом - целое рандомное число по порядку от 1 до 10
//         index++;
//     }
// }

// void PrintArray(int[] arr2) // метод вывода массива на экран
// {
//     int length2 = arr2.Length;
//     int index2 = 0;
//     while (index2 < length2)
//     {
//         Console.Write($"{arr2[index2]} ");
//         index2++;
//     }
// }    


// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int [] array = new int[N];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// Console.WriteLine("Введите искомую цифру ");
// int x = Convert.ToInt32(Console.ReadLine());

// int index = 0;
// bool find = false;
//   foreach (int item in array ) 
// {
//     if (item == x )
//     {
//         find = true;
//         break;  // прервать, чтобы он дальше не искал
//     }
// }    
// if (!find) Console.WriteLine("NO"); //восклицательный знак - не равно
// else Console.WriteLine("YES");


// Задача 35: Задайте одномерный массив из 15 случайных чисел от -50 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5 элементов. В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int [] FillArray(int size) //метод заполнения массива
// {
//     int [] array = new int [size];
//     for (int i = 0; i< array.Length; i++)
//     {
//         array[i] = new Random().Next(-50,100);
//         if (i != array.Length - 1) Console.Write ($"{array[i]}, ");
//         else Console.WriteLine($"{array[i]}");
//     }
//     return array;
// }

// int[] array = FillArray(15);
// int sum = 0;

// foreach (int item in array ) //работает для объявленных или созданных массивов по очереди перебирает ЗНАЧЕНИЯ - сначала item = a[0] потом a[1] и тд (тип переменных совпадает с переменными массива)
// {
//     if (item > 10 || item < 99) sum += item;
// }
// Console.WriteLine ($"Сумма эл-тов равна {sum}");



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void FillArray(int[] arr) //метод заполнения массива

{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random ().Next(1,10); // рандом - целое рандомное число по порядку от 1 до 10
    }
}

void PrintArray(int[] arr2) // метод вывода массива на экран
{
    for (int i = 0; i < arr2.Length; i++)
    {
        Console.Write($"{arr2[i]} ");
    }
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N]; //создать массив из N чисел (по умолчанию они все будут равны 0)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int [] array2 = new int [N/2 + N%2];

int j = N - 1;

for ( int i = 0; i < N/2; i++)
{
    array2[i] = array[i] * array[j-i];
}
if (N % 2 == 1) array2[N/2] = array[N/2];

PrintArray(array2);