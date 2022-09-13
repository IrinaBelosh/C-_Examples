// // Отсортировать массив по возрастанию значений элементов

// int[] arr = { 12, 85, 3, 3, 96, 45, 24, 56, 74, 45, 5, 5, }; //Задан массив

// void PrintArray(int[] array) //Функция печатает массив в строчку
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array) //Функция отсортировывает элементы по возрастанию значений.
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int min = i; //Задаем нулевой индекс как минимальный
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[min]) min = j; //сравниваем элементы от 1 до последнего с нулевым как с минимальным.
//         }
//         int temp = array[i]; //меняем элементы на старом min и на новом значении
//         array[i] = array[min];
//         array[min] = temp;
//     }
// }

// PrintArray(arr); //печатаем первый массив
// SelectionSort(arr); //отсортировываем
// PrintArray(arr); //печатаем полученный рензультат

// // Отсортировать массив по убыванию значений элементов

// int[] arr = { 12, 85, 3, 3, 96, 45, 24, 56, 74, 45, 5, 5, }; //Задан массив

// void PrintArray(int[] array) //Функция печатает массив в строчку
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array) //Функция отсортировывает элементы по возрастанию значений.
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int max = i; //Задаем нулевой индекс как минимальный
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[max]) max = j; //сравниваем элементы от 1 до последнего с нулевым как с минимальным.
//         }
//         int temp = array[i]; //меняем элементы на старом min и на новом значении
//         array[i] = array[max];
//         array[max] = temp;
//     }
// }

// PrintArray(arr); //печатаем первый массив
// SelectionSort(arr); //отсортировываем
// PrintArray(arr); //печатаем полученный рензультат

// Отсортировать случайный массив по возрастанию значений элементов

int[] arr = new int[12]; //Задано имя нового массива

void RandomArray (int[] arr) //Задана функция, которая заполняет массив случайными числами
{ 
    for (int i = 0; i< arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array) //Функция печатает массив в строчку
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) //Функция отсортировывает элементы по возрастанию значений.
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i; //Задаем нулевой индекс как минимальный
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[min]) min = j; //сравниваем элементы от 1 до последнего с нулевым как с минимальным.
        }
        int temp = array[i]; //меняем элементы на старом min и на новом значении
        array[i] = array[min];
        array[min] = temp;
    }
}

RandomArray(arr); //заполняем массив случайными числами
PrintArray(arr); //печатаем полученный случайный массив
SelectionSort(arr); //отсортировываем
PrintArray(arr); //печатаем полученный результат