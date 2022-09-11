// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// void PrintMaxDigit()
// {
//     int x = new Random().Next(10 ,100); //генерируем случайное число от 10 до 99. пишем справа 100 потому что правая граница не входит в зону
//     Console.WriteLine($"сгенерировалась случайное число {x}"); // $ - переформатирование в текст
//     int x1 = x / 10;
//     int x2 = x % 10;
//     if (x1 > x2) Console.WriteLine (x1);
//     else Console.WriteLine (x2);
// }

// PrintMaxDigit();
// PrintMaxDigit();


// void PrintMaxDigitArg(int xx)
// {
//    // Console.WriteLine($"сгенерировалась случайное число {xx}"); // $ - переформатирование в текст
//     int x1 = xx / 10;
//     int x2 = xx % 10;
//     if (x1 > x2) Console.WriteLine (x1);
//     else Console.WriteLine (x2);
// }

// PrintMaxDigitArg(int.Parse(Console.ReadLine())); // сразу информацию вводимое с клавы преобразую в целое число и передаю на вход

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// 1 уровень - обернуть в функцию, 
// 2 уровень - чтоб удалялась вторая цифра числа любой разрядности

// void Example()

    // {
        //int x = new Random().Next(100 ,1000); //генерируем случайное число от 100 до 999. пишем справа 1000 потому что правая граница не входит в зону
        // Console.WriteLine($"Случайное трехзначное число {x}"); // $ - переформатирование в текст
        // // int x1 = x / 100;
        // // int x2 = x1 * 10;
        // // int x3 = x % 10;
        // // int x4 = x2 + x3;
        // // Console.WriteLine (x4);

        // // другой вариант

        // int a = x / 100;
        // int b = x % 10;
        // Console.WriteLine ($"{a}{b}"); //если написать консольврайт то не надо переводить через $ 
        //($ - это сигнал комплилятору что сейчас будут значения переменных, и потом в фигурных скобках мы прописываем переменные
    //}
   
//Example();

// функция ретерн -"отвечает" программе ответ. Получит

// string Example (int x)
// {
//      int a = x / 100;
//      int b = x % 10;
//      return $"{a}{b}"; 

// }
// int x = new Random().Next(100,1000);
// Console.WriteLine($"сгенерировалось число {x}");

// Console.WriteLine(Example(x)+ " moved kuda-to");

            // 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
            //является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
            // 34, 5 -> не кратно, остаток 4
            // 16, 4 -> кратно

// Console.WriteLine ("Введите 1 число");
// int a = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите 2 число");
// int b = Convert.ToInt32 (Console.ReadLine ());
// if (a > b)
// {
//     if (a % b == 0) Console.WriteLine($"{b} кратно {a}");
//     else Console.WriteLine ($"не кратно, остаток {a % b}");
// }
// else if (b > a)
// {
//     if (b % a == 0) Console.WriteLine($"{a} кратно {b}");
//     else Console.WriteLine ($"не кратно, остаток {b % a}");
// }

            // то же самое задание, через ретерн

// string PrintOst()
// {
//     Console.WriteLine ("Введите 1 число");
//     int a = Convert.ToInt32 (Console.ReadLine ());
//     Console.WriteLine ("Введите 2 число");
//     int b = Convert.ToInt32 (Console.ReadLine ());

//     int ostat = a % b;
//     if (ostat == 0) return "кратно";
//     else return $"не кратно, остаток {ostat}";
// }
// Console.WriteLine (PrintOst());


            // тоже самое задание через воид

void Kratnoe(int a, int b)
{
    if (a % b == 0) Console.WriteLine($"{b} кратно {a}");
    else Console.WriteLine ($"не кратно, остаток {a % b}");
}

void Print(int x, int y)
{
    if (y > x) Kratnoe (y,x);
    else Kratnoe(x,y);
}

int xx = Convert.ToInt32(Console.ReadLine()); //parse  то же самое что и convert.toint32
int yy = Convert.ToInt32(Console.ReadLine());

Print(xx,yy);
Print(xx,yy);