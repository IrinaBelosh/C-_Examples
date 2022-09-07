// Найдите максимальное число из девяти используя массив

Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
    int maxim = arg1;
    if (arg2 > maxim) maxim = arg2;
    if (arg3 > maxim) maxim = arg3;
    return maxim;
}
int[] array = {52,77,32,14,69,15,21,74,88};

int max = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);

// Можно записать так
// int max = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8]));
// Console.WriteLine(max);