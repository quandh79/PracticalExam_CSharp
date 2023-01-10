using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Lion(250, "Simba");
            a1.Show();
            a1.SetMe(300, "Simba");
            a1.Show();

            Animal a2 = new Tiger(200, "Tony");
            a2.Show();
            a2.SetMe(250, "Tony");
            a2.Show();
        }
    }
}
