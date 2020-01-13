using System;
using System.Collections.Generic;
using System.Text;

namespace LearningGit
{
    internal class ClassA
    {
        private int Id { get; }
        private string Name { get; }

        public ClassA(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("{0} {1}", Id, Name);
        }
    }
}
