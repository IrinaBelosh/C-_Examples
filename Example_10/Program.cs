// Найти первый индекс числа find в массиве.
Console.Clear();
int[] array = { 1, 75, 4, 16, 2, 4, 11, 3, 9 };
int size = array.Length;
int find = 4;
int index = 0;
    while (index < size)
    {
        if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
        index++;
    }


