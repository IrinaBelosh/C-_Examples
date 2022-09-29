// Задача 1: Собрать строку с числами от А до В (A<=B)

// // Итеративный способ
// string Numbers(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// //Рекурсивный способ
// string Numbers(int a, int b)
// {
//     if (a <= b) return $"{a} " + Numbers(a + 1, b); //Если поменять элементы вывода местами, то строка будет собираться от большего к меньшему. (if (a <= b) return Numbers(a + 1, b) + $"{a}")
//     else return string.Empty;
// }
// Console.WriteLine(Numbers(1, 10));


//Задача 2: Найдите сумму чисел от 1 до Н

// //Итеративный метод
// int Sum(int n)
// {
//     int result = 0;
//     for (int i = 1; i<=n; i++) result +=i;
//     return result;
// }
// //рекурсивный метод
// int Sum(int n)
// {
//     if (n==0) return 0;
//     else return n+Sum(n-1);
// }
// Console.WriteLine(Sum(10));

//Задача 3: Факториал числа
// //Итеративный метод
// int Fact(int num)
// {
//     int result = 1;
//     for (int i = 1; i <= num; i++) result *= i;
//     return result;
// }
// //рекурсивный метод
// int Fact(int num)
// {
//     if (num == 1) return 1;
//     else return num * Fact(num - 1);
// }
// Console.WriteLine(Fact(10));

//Задача 5: Вычислить А в степени В
// //Итеративный метод
// int Square(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++) result *= a;
//     return result;
// }
// //Рекурсивный метод
// int Square(int a, int b) 
// {
//     if (b == 0) return 1;              //n==0? 1: Square(a,b-1)*a;
//     else return Square(a, b - 1) * a;
// }
// Console.WriteLine(Square(2,3));

//Задача 5: В машинном алфавите есть 4 буквы. Покажите все слова, состоящие из Т букв, которые можно построить из этого алфавита
// //Итеративный метод (Т=3)
// char[] alphabet = { 'a', 'b', 'c', 't' };
// int count = alphabet.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//     for (int j = 0; j < count; j++)
//     {
//         for (int k = 0; k < count; k++)
//         {
//             Console.WriteLine($"{n++} - {alphabet[i]}{alphabet[j]}{alphabet[k]}");
//         }
//     }
// }

//рекурсивный метод
int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
        if (length==word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++) //i-внутренняя(4раза) i-внешняя(4 раза)
    {
        word[length] = alphabet[i]; //00,10/00,11/00,12/00,13/01,10/01,11/01,12/01,13/02,10
        FindWords(alphabet, word,length+1);//
    }
}
FindWords("afik", new char[2]);