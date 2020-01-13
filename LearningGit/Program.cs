using System;
using System.Runtime.CompilerServices;

namespace LearningGit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DoSomethingWithClassA();
        }

        private static void DoSomethingWithClassA()
        {
            var a = new ClassA(1, "name1");

            a.DisplayInfo();
        }
    }
}
