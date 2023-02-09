using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M_Exam.Exercies2
{
    internal abstract class Animal
    {
        public double Weight { get; set; }
        public string Name { get; set; }

        //Constructors
        public Animal()
        {
        }
        public Animal(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        //Other methods
        public abstract void Show();

        public abstract void SetMe(double weight, string name); //Giong construcor nhi ?
    }
}
