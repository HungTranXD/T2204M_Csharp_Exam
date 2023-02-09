using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M_Exam.Exercies2
{
    internal class Lion : Animal
    {
        //Constructor
        public Lion()
        {
        }
        public Lion(double weight, string name) : base(weight, name)
        {
        }

        //Overide abstract methods
        public override void Show()
        {
            Console.WriteLine("Name: " + Name + ", Weight: " + Weight);
        }
        public override void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

    }
}
