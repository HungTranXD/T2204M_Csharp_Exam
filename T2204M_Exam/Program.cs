using T2204M_Exam.Exercies1;
using T2204M_Exam.Exercies2;

public class Program
{
    public static void Main(string[] args)
    {
        //Exercies 1: 
        //Cylinder c = new Cylinder();
        //Console.WriteLine("Enter the dimension of the cylinder");
        //Console.Write("Radius: ");
        //c.Radius = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Height: ");
        //c.Height = Convert.ToDouble(Console.ReadLine());

        //c.Process();
        //c.Result();

        //Exercies 2:
        Lion l = new Lion();
        l.SetMe(200, "lion");
        Tiger t = new Tiger();
        t.SetMe(100, "tiger");

        l.Show();
        t.Show();
        
    }
}
