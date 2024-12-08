using System.Linq.Expressions;

namespace Lesson4task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String symbol;

            Console.Write("Перемещение фигуры:\n W - вверх\n S - вниз\n A - влево\n D - вправо\n");

            while (true)
            {

                Console.Write("Введите символ для перемещения фигуры:");
                symbol = Console.ReadLine();

                while (symbol.Length > 1)
                {
                    Console.WriteLine("Было введено больше одного символа");
                    Console.Write("Введите символ для перемещения фигуры:");
                    symbol = Console.ReadLine();
                }

                switch (symbol)
                {
                    case ("W"):
                    case ("w"):
                        Console.WriteLine("Фигура перемещена вверх");
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("Фигура перемещена вниз");
                        break;
                    case "A":
                    case "a":
                        Console.WriteLine("Фигура перемещена влево");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Фигура перемещена вправо");
                        break;
                    default:
                        Console.WriteLine("Перемещения фигуры не произошло");
                        break;
                }
            }
        }
    }
}
