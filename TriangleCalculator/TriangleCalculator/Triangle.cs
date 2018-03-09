using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private string description;
        private bool right;
        private bool equilateral;
        private bool isosceles;
        private bool triangle;

        public Triangle()
        {
            sideA = 0;
            sideB = 0;
            sideC = 0;
            description = "These side lengths do not produce a valid triangle.";
            right = false;
            equilateral = false;
            isosceles = false;
            triangle = false;
        }


        // Runs all calculations on given side lengths in order to define the triangle.
        private void calculateTriangle()
        {
            if (isTriangle())
            {
                isRight();
                isEquilateral();
                isIsosceles();
            }
            else
            {
                right = false;
                equilateral = false;
                isosceles = false;
            }
            describeTriangle();
        }

        // Builds a string which describes the given triangle.
        private void describeTriangle()
        {
            StringBuilder sb = new StringBuilder();
            if (triangle)
            {
                sb.Append("These side lengths produce a valid ");
                if (equilateral)
                {
                    sb.Append("equilateral ");
                }
                else
                {
                    if (isosceles)
                    {
                        sb.Append("isosceles ");
                    }
                    if (right)
                    {
                        sb.Append("right ");
                    }                    
                }

                sb.Append("triangle.");
            }
            else
            {
                sb.Append("These side lengths do not produce a valid triangle.");
            }

            description = sb.ToString();
        }

        private bool isTriangle()
        {
            bool result = true;

            if(sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                result = false;
            }

            if(sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            {
                result = false;
            }

            triangle = result;
            return result;
        }

        private bool isRight()
        {
            bool result = false;

            double a2 = sideA * sideA;
            double b2 = sideB * sideB;
            double c2 = sideC * sideC;

            if(a2 + b2 == c2 || b2 + c2 == a2 || c2 + a2 == b2)
            {
                result = true;
            }

            right = result;
            return result;
        }

        private bool isEquilateral()
        {
            bool result = false;

            if(sideA == sideB && sideA == sideC)
            {
                result = true;
            }

            equilateral = result;
            return result;
        }

        private bool isIsosceles()
        {
            bool result = false;

            if(sideA == sideB || sideB == sideC || sideC == sideA)
            {
                result = true;
            }

            isosceles = result;
            return result;
        }

        public double SideA
        {
            get
            {
                return sideA;
            }

            set
            {
                sideA = value;
                calculateTriangle();
            }
        }

        public double SideB
        {
            get
            {
                return sideB;
            }

            set
            {
                sideB = value;
                calculateTriangle();
            }
        }

        public double SideC
        {
            get
            {
                return sideC;
            }

            set
            {
                sideC = value;
                calculateTriangle();
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }
    }
}
