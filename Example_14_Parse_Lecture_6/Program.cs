// Способы Parse
using System.Linq;
string text = "(1,2) (2,3) (3,4) (4,5) (5,6)"
                .Replace("(", "")
                .Replace(")", "");
// Console.WriteLine(text);

var data = text.Split(" ") // при первом прокате это тип string, потом массив массивов из двух элементов
                .Select(item => item.Split(",")) //теперь можно работать с item1, item2
                .Select(coord => (x: int.Parse(coord[0]), y: int.Parse(coord[1]))) //переводим в числа и именуем их//замена скобок перестанет работать тут
                .Where(coord => coord.x % 2 == 0)
                .Select(point => (point.x * 10, point.y + 10))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]); //(data[i].item1*10)=(data[i].x*10) - так как в 10 строке дали им названия
    Console.WriteLine();
}