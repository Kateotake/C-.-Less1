// Функция мах
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }

// int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

// Console.WriteLine(max);



//с массивом

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2 > result) result = arg2;
//     if(arg3 > result) result = arg3;
//     return result;
// }
// //               0   1   2   3   4   5   6   7   8              - индекс массива
// int [] array ={ 11, 12, 13, 34, 75, 89, 39, 83, 93};
// array [0] = 12; //можно присвоить новое значение
// Console.WriteLine(array[4]);




// есть массив из н элементов,найти элемент массива равный "файнд"

// int [] array ={ 11, 12, 13, 34, 75, 89, 34, 39, 83, 93};

// int n = array.Length;
// int find = 34;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;  // прервать, чтобы он дальше не искал
//     }
//     index++;
// }


//______________________________________________
//метод заполнения массива

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random ().Next(1,10); // рандом - целое рандомное число по порядку от 1 до 10
        index++;
    }
}

// метод вывода массива на экран
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{ 
    int count = collection.Length;
    int index = 0;
    int position = -1; // если элемента искомого нет, то позиция (номер индекса массива) будет равен -1. просто чтобы не ноль

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;  
            break;
        }
        index++;
      
    }
    return position;
}

int [] array = new int[10]; //создать массив из 10 чисел (по умолчанию они все будут равны 0) массив называется эррей

FillArray(array);
array [4] = 4; //принудительно вставляем четверки в наш массив
array [7] = 4; 
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4); // ищем четверки в массиве эррей
Console.WriteLine(pos);

















