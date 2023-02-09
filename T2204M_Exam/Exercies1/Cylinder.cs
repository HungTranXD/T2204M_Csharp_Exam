using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M_Exam.Exercies1
{
    internal class Cylinder
    {
        //Auto-implemented properties:
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; private set; } //Read-only
        public double LateralArea { get; private set; } //Read-only
        public double TotalArea { get; private set; } //Read-only
        public double Volumn { get; private set; } //Read-only

        //Constructors:
        public Cylinder()
        {
        }
        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
            Process();
        }

        //Other methods
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volumn = Math.PI * Radius * Radius * Height;
        }
        
        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ", Height: " + Height);
            Console.WriteLine(
                "Base: " + string.Format("{0:0.00}", BaseArea) 
                + " | Lateral: " + string.Format("{0:0.00}", LateralArea) 
                + " | ToTal: " + string.Format("{0:0.00}", TotalArea) 
                + " | Volumn: " + string.Format("{0:0.00}", Volumn));
        }
    }
}
