namespace Lesson4task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Все двузначные числа кратные 5:");
            for (var i = -99; i < 100; i++)
            {
                if ((i % 5 == 0)&&((i<-9)||(i>9)))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
