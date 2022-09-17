// все задачи были аналогичны лекции кроме

//Задача 67: Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumCifr (int N)
{
   if (N == 0 ) return 0;
   else return N % 10 + SumCifr(N/10);
}
// int res = 0;
// while (N !=0)
// {
//     res = res + N % 10;
//     N = N / 10;
// }
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumCifr(N));
