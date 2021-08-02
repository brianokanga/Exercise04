using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise04
{
    public class Cirle : Shape
    {
        public double Radius { get; set; }
        
        private double PI = Math.PI;

        public Cirle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return PI * Radius * Radius ;
        }
    }
}
