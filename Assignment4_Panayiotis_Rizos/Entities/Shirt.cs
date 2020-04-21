using Assignment4_Panayiotis_Rizos.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Panayiotis_Rizos.Entities
{
    class Shirt
    {

        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }


        public Shirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }


        public void Output() 
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}",Size,Color,Fabric);
        }

    }
}
