﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculatePerimeter()
        {
            return this.height * 2 + this.width * 2;
        }

        public override double CalculateArea()
        {
            return this.height * this.width;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
