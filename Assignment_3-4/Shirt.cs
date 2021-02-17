using Assignment_3_4.Enumerators;
using Assignment_3_4.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4
{
   public class Shirt : IProduct
    {
        public Color Color { get; set; }

        public Size Size { get; set; }

        public Fabric Fabric { get; set; }

        private double _basePrice = 50.0;

        public Shirt(Color color, Size size, Fabric fabric )
        {
            Color = color;
            Size = size;
            Fabric = fabric;           
        }
         
            

        public void ShowDetails()
        {
            Console.WriteLine("Your shirt is {0} | {1} | {2}", Color, Size, Fabric);
        }

        public double GetCost()
        {
            return (double)(_basePrice * (100 + (int)Color + (int)Size + (int)Fabric) / 100);
        }

        public void Output()
        {
            Console.WriteLine("{0, 12} | {1, 12} | {2, 12}", Color, Size, Fabric);
        }
    }
}
