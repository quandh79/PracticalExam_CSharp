using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample.exercise1
{
    public class Cylinder
    {
        public double radius { get; set; }
        public double height { get; set; }

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            BaseArea = Math.PI * radius * radius;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public double BaseArea { get; private set; }
        public double LateralArea { get; private set; }
        public double TotalArea { get; private set; }
        public double Volume { get; private set; }
        public string Result()
        {
            
            return "radius: " + radius + "\n" + "height: " + height + "\n" + "Base Area: " + Math.Round(BaseArea, 2) + "\n" +
                    "Lateral Area: " + Math.Round(LateralArea, 2) + "\n" +
                    "Total Area: " + Math.Round(TotalArea, 2) + "\n" +
                    "Volume: " + Math.Round(Volume, 2);
        }
    }
}
