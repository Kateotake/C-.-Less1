//1. Напишите программу, которая на вход принимает два числа и проверяет,
//   является ли первое число квадратом второго.
//a = 5; b = 25 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> нет
//a = -3 b = 9 -> да

// Console.Write("Введите целое число a: ");
// int a = Convert.ToInt32(Console.ReadLine());//converttoint32 переводит "строку" в "число". Ридлайн принимает значение стринг, ей нужно показать что наше число не стринг, а инт
// Console.Write("Введите целое число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a * a == b)
// {
//     Console.WriteLine("Да!");
// }

// else if (b * b == a)
// {
//     Console.WriteLine("Да!");
// }

// else
// {
//     Console.WriteLine("Нет");
// }

// закомментировать - ctrl+k+c







//2. Напишите программу, которая будет выдавать название дня недели
//   по заданному номеру.
//3 -> Среда
//5 -> Пятница



// Console.Write("Введите целое число от 1 до 7: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a == 1) Console.WriteLine("Понедельник");

// else if(a == 2) Console.WriteLine("Вторник");

// else if(a == 3) Console.WriteLine("Среда");

// else if(a == 4) Console.WriteLine("Четверг");

// else if(a == 5) Console.WriteLine("Пятница");

// else if(a == 6) Console.WriteLine("Суббота");

// else if(a ==7) Console.WriteLine("Воскресенье");

// else Console.WriteLine("Нет такого дня недели");


// 3. Программа которая проверяет при вводе трех чисел, не является ли какое-либо число произведенеим двух других

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целое число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if ( a == b *c || b == a * c || c == a * b) Console.WriteLine("Да");
else Console.WriteLine("Нет");