// // Первый тип ничего не принимает и ничего не возвращает (void)

// void Method1() //Указывается тип void, скобки пустые
// {
//     Console.WriteLine("Author...");
// }
// Method1(); //Форма вызова такого типа методов

// //Второй тип что-то принимает, но ничего не возвращает (void)
// void Method2(string msg) // Указываем в скобках аргумент, с которым метод будет работать
// {
//     Console.WriteLine(msg);
// }
// Method2("Text of the message"); //Вызов метода второго типа. Указываем необходимый аргумент в скобках

// // Аргументы, при вызове метода, могут быть именованными, например
// void Method21(string msg, int count) // Указываем в скобках аргумент, с которым метод будет работать
// {
//     int i = 0;
//     while(i<count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// // Method21("Text of the message", 4); //Можно указывать обычным способом
// // Method21(msg: "Text of the message", count: 4); //Можно указывать именованными
// Method21(count: 4, msg: "Text of the message"); //Если аргументы именованные, то можно их писать не по порядку

// //Третий тип методов, ничего не принимает, но что-то возвращает
// int Method3() //обязательно указываем какой тип данных будет возвращаться int, в скобках аргументов нет
// {
//     return DateTime.Now.Year; //обязательно используем return, что возвращает метод
// }
// int year = Method3();//Вводим идэнтификатор переменной, куда кладем результат работы метода
// Console.WriteLine(year); //Дальше работаем уже с этой переменной

// //Четвертый тип, что-то принимает и что-то возвращает
// string Method4(int count, string text) //Указываем выходной тип переменной и аргументы
// {
//     int i = 0;
//     // string result = ""; //Можно пустую строку указать так
//     string result = String.Empty; //Можно указать так
//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result; //Обязательно указываем что возвращать
// }
// string res = Method4(10, "Text");//Кладем куда-то результат работы метода
// Console.WriteLine(res); //и потом работаем уже с полученной переменной

// //Цикл for, на примере 4го метода
// string Method4(int count, string text) //Указываем выходной тип переменной и аргументы
// {
//     // string result = ""; //Можно пустую строку указать так
//     string result = String.Empty; //Можно указать так
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result; //Обязательно указываем что возвращать
// }
// string res = Method4(10, "Text");//Кладем куда-то результат работы метода
// Console.WriteLine(res); //и потом работаем уже с полученной переменной

// //Цикл в цикле (таблица умножения)
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// // Задача: В тексте замените все пробелы на черточки, маледбнькие буквы"к" на большие "К" 
// //и маленькие буквы "с" на большие "С"

// string Replace(string text, char oldValue, char newValue) // Пишем метод (char это символ)
// {
//     string result = String.Empty; //результат пустой
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";//или кладем новое значение
//         else result = result + $"{text[i]}"; //или кладем старое значение
//     }
//     return result;
// }

// string texte = "Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "Вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string newText = Replace(texte, ' ', '|'); //создаем переменную, куда кладем результат работы метода
// Console.WriteLine(newText); //выводим на печать
// Console.WriteLine(); //делаем пустую строку для отступа
// newText = Replace(texte, 'к', 'К'); //тут string можно не повторять, так как тип уже задан выше.
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(texte, 'с', 'С'); // Переменная char указывается в одинарных кавычках! 
// Console.WriteLine(newText);

// //string s = "fgdhskjs" 
// //            01234567 (позиция символа в строке)
// // s[3] -> h (обращаемся к строке как к массиву)
