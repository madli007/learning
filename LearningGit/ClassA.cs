using System;
using System.Collections.Generic;
using System.Text;

namespace LearningGit
{
    class ClassA
    {
        private int Id { get; set; }
        private string Name { get; set; }

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
