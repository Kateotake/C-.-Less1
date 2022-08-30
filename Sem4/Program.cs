// Задача с днями неделями через свитч дефолт

// Console.WriteLine("Введите номер дня недели");
// int x = int.Parse(Console.ReadLine());
// switch (x) // чтобы не использовать if else много раз - пишем switch (переключение) - если число варианта больше трех - так более красиво
// {
//     case 1: //в случае "1" пишем:
//         Console.WriteLine("это понедельник");
//         break; //завершаем обязательно
//      case 2:
//         Console.WriteLine("это вторник");
//         break;
//      case 3:
//         Console.WriteLine("это среда");
//         break;
//      case 4:
//         Console.WriteLine("это четверг");
//         break;
//      case 5:
//         Console.WriteLine("это пятница");
//         break;
//      case 6:
//         Console.WriteLine("это суббота");
//         break;
    
//     default: //аналог else
//         Console.WriteLine("номер некорректный");
//         break;
// }




// Печатает массив в консоль

// int [] array = {5, 6, 8, 11, 77, 55, 22};
// // foreach (int item in array) // аналог for . цикл проходит по "коллекции"(массиву)переменная item  по очереди принимает значения массива
// for (int i = 0; i < array.Length; i++)
// {
//    if ( i !=array.Length - 1) Console.Write($"{array[i]}, ");
//    else Console.WriteLine ($"{array[i]}"); // чтоб не было запятой
// }



//Задача 30: Напишите программу, которая выводит массив из N элементов, 
//заполненный случайными целыми числами. 
//N - целое число и задается с клавиатуры.


// Console.WriteLine("Введите целое число - кол-во элементов массива");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int[N];

// for (int i = 0; i < N; i++)
// {
//     arr[i] = new Random ().Next(1,100);
//     Console.Write($"{arr[i]} ");
// } 
// Console.WriteLine();
// Console.WriteLine(arr[0]);



// написать программу, где уже реализовано заполнение массива случайными числами. 
//И в этом массиве надо найти максимум и его индекс, минимум и его индекс, 
//среднее арифметическое всех элементов массива. Всё это обернуть в функции.


void FillArray(int[] arr) //метод заполнения массива

{
    int length = arr.Length;
    int index = 0;
    while (index < length)
    {
        arr[index] = new Random ().Next(1,10); // рандом - целое рандомное число по порядку от 1 до 10
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

void MinMax(int[] arr3) // метод нахождения минимума и максимума
{
    int i = 0;
    int j = 0;
    int maxPos = 0;
    int minPos = 0; 
    while ( i < arr3.Length)  
    {
        if (arr3[i] < arr3[minPos]) minPos = i;
        i++;
    }
      Console.WriteLine($"Минимальное значение массива - {arr3[minPos]}, номер индекса {minPos}");
        
    while (j < arr3.Length)
    {
        if (arr3[j] > arr3[maxPos]) maxPos = j;
        j++;
    }
     Console.WriteLine($"Максимальное значение массива - {arr3[maxPos]}, номер индекса {maxPos}");
}

void SredArif (int [] arr4)
{
    double sum = 0;
    
    for (int i = 0; i < arr4.Length; i++)
    {
        sum = sum + arr4[i];
    }
    double sred = sum / arr4.Length;
    Console.WriteLine($"Среднее арифметическое всех элементов массива равно {sred}");
}

Console.WriteLine("Введите целое число - кол-во элементов массива");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [] array = new int[N]; //создать массив из N чисел (по умолчанию они все будут равны 0)

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
MinMax(array);
Console.WriteLine();
SredArif(array);

// int pos = IndexOf(array,4); // ищем четверки в массиве эррей
// Console.WriteLine(pos);









