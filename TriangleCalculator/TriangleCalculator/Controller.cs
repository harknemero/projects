using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    class Controller
    {
        Triangle triangle;

        public Controller()
        {
            triangle = new Triangle();
        }

        public void setSideA(double length)
        {
            triangle.SideA = length;
        }

        public void setSideB(double length)
        {
            triangle.SideB = length;
        }

        public void setSideC(double length)
        {
            triangle.SideC = length;
        }

        public string getDescription()
        {
            return triangle.Description;
        }
    }
}
