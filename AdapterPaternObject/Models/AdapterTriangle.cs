using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPaternObject.Models
{
    internal class AdapterTriangle : IRect
    {
        private Triangle triangleObj;
        public AdapterTriangle(Triangle triangle) 
        {
            triangleObj = triangle;
        }
        public void AboutRectangle()
        {
            triangleObj.AboutTriangle();
        }

        public double CalculateRectangle()
        {
          return  triangleObj.CalculateTriangle();
        }
    }
}
