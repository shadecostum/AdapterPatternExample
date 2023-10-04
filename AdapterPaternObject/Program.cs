using AdapterPaternObject.Models;

namespace AdapterPaternObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 7);
            rectangle.AboutRectangle();
            Console.WriteLine(rectangle.CalculateRectangle());

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Triangle triangle=new Triangle(5,7);
            //triangle.AboutTriangle();
           // Console.WriteLine(triangle.CalculateTriangle());
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            IRect adapterTriangle=new AdapterTriangle(triangle);
            Console.WriteLine(GetArea(adapterTriangle)); 
            // adapterTriangle.AboutRectangle();
            // Console.WriteLine(adapterTriangle.CalculateRectangle());
        }

        public static double GetArea(IRect adapter)
        {
            adapter.AboutRectangle();
            return adapter.CalculateRectangle();
        }
    }
}