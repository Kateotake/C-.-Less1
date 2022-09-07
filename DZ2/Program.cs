// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.Write ("Введите трехначное число ");
// int  N = Convert.ToInt32(Console.ReadLine());
// int a = N % 100;
// Console.WriteLine(a/10);
















// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write ("Введите целое число ");
// string chislo = Console.ReadLine();
// int dlina_chisla = chislo.Length; 
// int N = Convert.ToInt32(chislo); 
// int i = 0;

// if (dlina_chisla >= 3)
// {
//     while (i < (dlina_chisla - 3)) //пока i не дойдет третьей цифры , делим N на 10
//         {
//             N = N/10;
//             i++;
//         }

// Console.WriteLine(N % 10);
// }
// else  Console.WriteLine ("третьей цифры нет");














// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру от 1 до 7 ");

// int a = Convert.ToInt32(Console.ReadLine());

// if(a == 1) Console.WriteLine("Нет");
// else if(a == 2) Console.WriteLine("Нет");
// else if(a == 3) Console.WriteLine("Нет");
// else if(a == 4) Console.WriteLine("Нет");
// else if(a == 5) Console.WriteLine("Нет");
// else if(a == 6) Console.WriteLine("Да");
// else if(a ==7) Console.WriteLine("Да");
// else Console.WriteLine("Такого дня недели я не знаю");














// необязательная задача.
// В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, 
//по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

// Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), 
//выводящее это число в консоль вместе с правильным образом изменённым словом "программист", 
//для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.

// В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.


//  Console.WriteLine ("Введите число программистов: ");

// int n = Convert.ToInt32(Console.ReadLine());

// if(n % 10 == 1 ) Console.WriteLine($"В комнате {n} программист");
// else if(n % 10 == 2 || n % 10 == 3 ||n % 10 == 4  ) Console.WriteLine($"В комнате {n} программиста");
// else Console.WriteLine($"В комнате {n} программистов");









// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Stepen(int A , int B)
// {
//     int stepn = 1;

//     for (int i = 0; i < B; i++)
//     {
//         stepn = stepn * A ;
//     }
//     return stepn;
// }

// Console.WriteLine("Введите целое число А");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите целое число В");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ($"{x} в степени {y} равно {Stepen(x,y)}");



//  Console.WriteLine("Введите целое число А");
// double A = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите целое число В");
// double B = Convert.ToDouble(Console.ReadLine());

// double step = Math.Pow(A , B);

// Console.WriteLine(step);








// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine ("Введите целое число");
// string N = Console.ReadLine();
// int NN = Convert.ToInt32(N);
// int ost = 0;
// int sum =  0;

// for (int i = 0; i <= N.Length; i++)
// {
//     ost = NN % 10;
//     NN = NN /10;
//     sum = sum + ost;
// }
// Console.WriteLine(sum);




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// int [] arr = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     arr[i] = new Random ().Next(1,100);
//     Console.Write($"{arr[i]} ");
// } 

// void PrintArray(int[] arr2) 
// {
//     int length2 = arr2.Length;
//     int index2 = 0;
//     while (index2 < length2)
//     {
//         Console.Write($"{arr2[index2]} ");
//         index2++;
//     }
// }


// int [] arr = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     int a = Convert.ToInt32(Console.ReadLine());
//     arr[i] = a;
// } 

// PrintArray(arr);


// необязательная задача
// Написать программу, которая сортирует массив от большего к меньшему и находит медианное значение.
//  Массив заполняется случайными целыми числами от 1 до 100, а его размерность вводится с клавиатуры




void FillArray(int[] arr) //метод заполнения массива

{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random ().Next(1,100); // рандом - целое рандомное число по порядку от 1 до 10
        index++;
    }
}

void PrintArray(int[] arr2) // метод вывода массива на экран
{
    int length2 = arr2.Length;
    int index2 = 0;
    while (index2 < length2)
    {
        Console.Write($"{arr2[index2]} ");
        index2++;
    }
}

//Пишем метод который будет упоряд наш массив
void Selection(int[] arr3) //в качестве аргумента приходит массив
{
    for (int i = 0; i < arr3.Length - 1; i++) //отнимаем единичку потому что поиск будет вестись с позиции i+1 
    {
        int maxPos = i; //переменная ПОЗИЦИИ на которой находится минимальный элемент, присваиваем ПОЗИЦИЮ i(0, 1,2 и тд)

        for (int j = i + 1; j < arr3.Length; j++) // цикл ищет с нового значения позиции j - она всегда больше i на единицу
        {
            if (arr3[j] > arr3[maxPos]) 
            {
                maxPos = j; // меняем местами 
            }

        }

        int temp = arr3[i];
        arr3[i] = arr3[maxPos];
        arr3[maxPos] = temp;
    }
}



Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] array = new int[N];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Selection(array);
PrintArray(array);
Console.WriteLine();

double med = 0;
if (N % 2 == 1)
{
    med = array[(N - 1)/2];
}
else 
{
    int med1 = array[N / 2] ; 
    int med2 = array[(N - 2)/2] ;

    med = Convert.ToDouble(med1 + med2) /2;
} 

Console.WriteLine ($"Медианное значение данного массива - {med}");