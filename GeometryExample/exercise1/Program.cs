using GeometryExample.exercise1;

class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder(38.64, 22.48);
        cylinder.Process();
        Console.WriteLine(cylinder.Result());
       
    }
}
