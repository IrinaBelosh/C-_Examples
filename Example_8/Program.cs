// Найти максимальное значение из 9 чисел, используя функции.
// Вариант третий. Функциональное програмирование без промежуточных переменных
Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int maxim = arg1;
    if (arg2 > maxim) maxim = arg2;
    if (arg3 > maxim) maxim = arg3;
    return maxim;
}
int a1 = 15;
int b1 = 92;
int c1 = 6;
int a2 = 25;
int b2 = 4;
int c2 = 56;
int a3 = 19;
int b3 = 85;
int c3 = 32;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);

// Вариант первый без функции.
// Console.Clear();
// int a1 = 15;
// int b1 = 45;
// int c1 = 96;
// int a2 = 25;
// int b2 = 4;
// int c2 = 56;
// int a3 = 19;
// int b3 = 68;
// int c3 = 32;
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
// Console.WriteLine(max);

// Вариант второй с функцией (методом) и промежуточными переменными max1, max2, max3
// Console.Clear();
// int Max(int arg1, int arg2, int arg3)
// {
//     int maxim = arg1;
//     if (arg2 > maxim) maxim = arg2;
//     if (arg3 > maxim) maxim = arg3;
//     return maxim;
// }
// int a1 = 15;
// int b1 = 45;
// int c1 = 6;
// int a2 = 25;
// int b2 = 4;
// int c2 = 56;
// int a3 = 19;
// int b3 = 68;
// int c3 = 32;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Console.WriteLine(max);
