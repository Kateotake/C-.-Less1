// rekursia
// необходимо прописать условие выхода дл рекурсии

//собрать строку с числами от а до b, а<=b
// without rec:

// string NumbersFor(int a, int b)
// {
//     string res = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         res += $"{i} ";
//     }
//     return res;
// }

// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
//     else return String.Empty; //условие выхода. если условие не выполнилось
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));



//сумма чисел от 1 до n

// int SumFor(int n)
// {
//     int res = 0;
//     for (int i = 1; i <= n; i++) res += i;
//     return res;
// }

// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n -1);
// }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));


//факториал числа

// int FactFor(int n)
// {
//     int res = 1;
//     for (int i = 1; i <= n; i++) res *= i;
//     return res;
// }

// int FactRec(int n)
// {
//     if (n==1) return 1;
//     else return n * FactRec(n-1);
// }
// Console.WriteLine(FactFor(10));
// Console.WriteLine(FactRec(10));

// вычислить a^n

// int PowerFor(int a, int n)
// {
//     int res = 1;
//     for (int i = 1; i <=n; i++) res *= a;
//     return res;
// }

// int PowerRec(int a, int n)
// {
//     return n == 0 ? 1 : PowerRec(a, n-1) * a;     //условие ниже можно записать и так
//     // if (n==0) return 1;
//     //else return PowerRec(a,n-1)*a;
// }

// Console.WriteLine(PowerFor(2,10));
// Console.WriteLine(PowerRec(2,10));

//перебор слов. есть буквы а и с в, покажите все слова состоящие из Т буквы,
//которые можно построить из букв этого алфамита



// int n =1;
// void FindWords(string alphabet, char[] word, int lenght = 0)
// {
//     if (lenght == word.Length)
//     {
//         Console.WriteLine($"{n++}  {new String(word)} ");
//         return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[lenght] = alphabet[i];
//         FindWords(alphabet, word, lenght + 1);
//     }
// }
// FindWords("аисв", new char[2]);

