            //цикл вайл. пусть вводит число и+1 пока не станет и равно 15

// Console.Write ("Введите целое число ");
// int i = 5;
// while (i <= 15)
// {
//     Console.Write(i+", ");
//     i++;                            //i++ это = i+1
// }


            // 5. Напишите программу, которая на вход принимает 
            //одно число (N), а на выходе показывает все целые 
            //числа в промежутке от -N до N.
            // 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
            // 2 -> " -2, -1, 0, 1, 2"


// Console.Write ("Введите целое число ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = -N; i <= N ; i++) Console.Write(i + ", ");




            // . Напишите программу, которая принимает на вход трёхзначное 
            //число и на выходе показывает последнюю цифру этого числа.
            // 456 -> 6
            // 782 -> 2
            // 918 -> 8

// Console.Write ("Введите целое число ");
// int  N = Convert.ToInt32(Console.ReadLine());
// int a = N % 10;
// Console.WriteLine(a);


            // При вводе четырехзначного числа выводится 3я цифра

// Console.Write ("Введите целое число ");
// int  N = Convert.ToInt32(Console.ReadLine());
// int a = N / 10;
// a = a % 10;
// Console.WriteLine(a);


Console.Write ("Введите целое число ");
string? N_str = Console.ReadLine();
int lnght = N_str.Length;
int  N = Convert.ToInt32(N_str);
int i = 0;

while (i < (lnght - 2))
{
    N = N/10;
    i++;
}

Console.WriteLine(N % 10);