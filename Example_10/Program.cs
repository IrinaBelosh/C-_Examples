// Найти первый индекс числа find в массиве.
Console.Clear();
int[] array = { 1, 75, 3, 16, 2, 6, 11, 3, 9 };
int size = array.Length;
int find = 4;
int index = 0;
if (index < size)
{
    while (index < size)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index);
        }
        index++;
    }
}
else
{
    Console.WriteLine("no match");
}

