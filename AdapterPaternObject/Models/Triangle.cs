using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPaternObject.Models
{
    internal class Triangle
    {
        double LengthTr;
        double WidthTr;

        public Triangle(double Length, double Width)
        {

            this.LengthTr = Length;
            this.WidthTr = Width;
        }

        public void AboutTriangle()
        {
            Console.WriteLine("This is Triangle ");
        }

        public double CalculateTriangle()
        {
            return 0.5* LengthTr * WidthTr;
        }
    }
}
