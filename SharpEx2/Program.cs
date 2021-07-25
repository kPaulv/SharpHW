using System;
using System.Threading;
using System.Threading.Tasks;

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

            Currency currencyPair = new Currency();
            Console.WriteLine($"1124.5 BYN in USD: {currencyPair.BynToUsd(1124.5)}");
            Console.WriteLine($"557.24 USD in BYN: {currencyPair.BynToUsd(1124.5)}");

            Student st1 = new Student("Alex", 54.6, 87.2, Calculator.CountDoubleMean(54.6, 87.2));
            Student st2 = new Student("Steve", 35.0, 88.67575, Calculator.CountDoubleMean(35.0, 88.67575));
            Student st3 = new Student("Nick", 67.6, 95.347, Calculator.CountDoubleMean(67.6, 95.347));

            StudentList students = new StudentList();
            students.AddStudent(st1);
            students.AddStudent(st2);
            students.AddStudent(st3);

            //CPU Bound Task on counting taylor row sum.
            AsyncMethodCaller.CallRowSumAsync();
        }
    }
}

