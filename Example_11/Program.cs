// Заполнить массив случайными числами и найти в нем номер позиции заданного числа.
//void - не возвращает элементы

Console.Clear();
void FillArray(int[] collection) // Фукция под названием FillArray, заполняет массив случайными числами
{
    int size = collection.Length;
    int index = 0;
    while (index < size)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //Функция под названием PrintArray, печатает элементы массива, задаваемые последдовательно
{
    int size2 = col.Length;
    int index2 = 0;
    while (index2 < size2)
    {
        Console.WriteLine(col[index2]);
        index2++;
    }
}

int IndexOf(int[] coll, int find) //Функция нахождения позиции числа find
{
    int size3 = coll.Length;
    int index3 = 0;
    int position = -1;
    while (index3 < size3)
    {
        if(coll[index3] == find)
        {
            position = index3;
            break;
        }
        index3++;
    }
    return position;
}

int[] array = new int[10]; //создать новый массив с 10 элементами
FillArray(array); // Обращение к функции заполнить массив
PrintArray(array); //Обращение к функции распечатать массив

Console.WriteLine(); //пустая строчка на выводе после распечатанного массива

int pos = IndexOf(array, 44); //Обращение к функции нахождения позиции искомого числа.
Console.WriteLine(pos);


