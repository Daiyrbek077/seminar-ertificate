//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write($"Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите значение M: ");
int M=Convert.ToInt32(Console.ReadLine());

void PrintLimitedNumbers(int start, int end)
{
    if (start == end)
    {
       Console.Write(start); 
       return;
    } 

    Console.Write(start + " ");

    PrintLimitedNumbers(start + 1, end);

}

PrintLimitedNumbers(N, M);




// // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int A(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return A(m - 1, 1);
//     else return A(m - 1, A(m, n - 1));
// }

// Console.Write(A(m, n));



// // Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] array = { 1, 2, 5, 0, 10, 34 };
// int size = array.Length-1;
// void ShowArray(int[] arr, int size)
// {
//     if (size == 0)
//     {
//         Console.Write(arr[size]);
//         return;
//     }
//     Console.Write(arr[size]+" ");

//     ShowArray(arr, size-1);
// }
// ShowArray(array, size);

