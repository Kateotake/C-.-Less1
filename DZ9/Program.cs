//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""


// string NumbersRec(int M, int N)
// {
//     if (M <= N) return $"{M} " + NumbersRec(M + 1, N);
//     else return String.Empty;
// }

// Console.WriteLine(NumbersRec(4, 10));


// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int SumRec(int M, int N)
// {
//     if (N < M) return 0;
//     else return N + SumRec(M, N -1);
// }

// Console.WriteLine(SumRec(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29
int Acc(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return Acc(n - 1, 1);
    else return Acc(n - 1, Acc(n, m - 1));
}

Console.WriteLine (Acc(3,2));