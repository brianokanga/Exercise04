using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => throw new NotImplementedException();

        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }

    }

}
