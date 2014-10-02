using System;
using System.Diagnostics;

namespace PerformanceCompareApp
{
    class Program
    {
        private const int count = 10000;
        static void Main(string[] args)
        {
            TestFsharp();
            TestCsharp();
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestFsharp()
        {
            var generator = new FSharpApp.PersonGenerator();
            var stopWatch = new Stopwatch();
            
            stopWatch.Start();
            var persons = generator.GetPersons(count);
            stopWatch.Stop();

            Console.WriteLine("F#: " + stopWatch.Elapsed.TotalSeconds.ToString() + " seconds");
        }

        private static void TestCsharp()
        {
            var generator = new CSharpApp.PersonGenerator();
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var persons = generator.GetPersons(count);
            stopWatch.Stop();

            Console.WriteLine("C#: " + stopWatch.Elapsed.TotalSeconds.ToString() + " seconds");
        }
    }
}
