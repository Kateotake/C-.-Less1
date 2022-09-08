//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите целое число ");
int num1= Convert.ToInt32(Console.ReadLine());
if (num1==0)
{
Console.WriteLine("Ноль и в Африке ноль, даже квадрат!");
}
else
{
num1=num1*num1;
Console.WriteLine("Квадрат введенного числа будет равен "+num1);
}