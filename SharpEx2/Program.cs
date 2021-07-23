using System;

namespace SharpEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Swapper sw = new Swapper
            {
                First = 5,
                Second = 10
            };
            Console.WriteLine($"First: {sw.First}, Second: {sw.Second}");
            sw.Swap();
            Console.WriteLine($"First: {sw.First}, Second: {sw.Second}");

            Student st1 = new Student
            {
                Name = "Alex",
                LowestGrade =  54.6,
                HighestGrade = 87.2
                    пизда
            };
        }
    }
}
