namespace Lesson4task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new int[] { 1, 2, 3, 10, 15, 20, 40, 42, 56 };

            Console.WriteLine("Вывод массива при помощи цикла for:");
            for (var i = 0; i < collection.Length; i++)
            {
                Console.Write($"{collection[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("Вывод массива при помощи цикла foreach:");
            foreach (var i in collection)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine("Вывод массива при помощи цикла while:");
            var index = 0;
            while (index < collection.Length)
            {
                Console.Write($"{collection[index]} ");
                index++;
            }
            Console.WriteLine();

            Console.WriteLine("Вывод массива при помощи цикла do...while:");
            var index2 = 0;
            do
            {
                Console.Write($"{collection[index2]} ");
                index2++;
            }
            while (index2 < collection.Length);
        }


    }
}
