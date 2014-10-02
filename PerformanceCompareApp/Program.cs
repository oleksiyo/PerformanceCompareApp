using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CSharpApp;

namespace PerformanceCompareApp
{
    class Program
    {
        private const int count = 10000;
        static void Main(string[] args)
        {
            TestCsharp();
            TestFsharp();
            Console.WriteLine("End");
            Console.ReadKey();
        }

        private static void TestFsharp()
        {
            var generator = new FSharpApp.PersonGenerator();
            var stopWatch = new Stopwatch();
            
            stopWatch.Start();
            var persons = generator.GetPersons(count).ToList();
            LogResult(persons);
            stopWatch.Stop();

            Console.WriteLine("F#: " + stopWatch.Elapsed.TotalSeconds.ToString() + " seconds");
        }

        private static void TestCsharp()
        {
            var generator = new CSharpApp.PersonGenerator();
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var persons = generator.GetPersons(count);
            LogResult(persons);
            stopWatch.Stop();

            Console.WriteLine("C#: " + stopWatch.Elapsed.TotalSeconds.ToString() + " seconds");
        }

        private static void LogResult(IEnumerable<dynamic> persons)
        {
            Console.Out.WriteLine("persons = {0}", persons.Sum(p => p.Id));
        }
    }
}
