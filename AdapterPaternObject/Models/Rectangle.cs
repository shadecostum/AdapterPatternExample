using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPaternObject.Models
{
    internal class Rectangle : IRect
    {
        double Length;
        double Width;

        public Rectangle(double Length, double Width)
        {

            this.Length = Length;
            this.Width = Width;
        }

        public void AboutRectangle()
        {
            Console.WriteLine("This is Rectangel");
        }

        public double CalculateRectangle()
        {
            return Length * Width;
        }
    }
}
