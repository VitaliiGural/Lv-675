﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gural_HW8
{
    public class Square : Shape
    {
        private double side;
        public double Side { get { return side; } }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 2 * (side + side);
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Side = " + side;
        }

        public override int CompareTo(object obj)
        {
            return this.Perimeter().CompareTo((obj as Shape).Perimeter());
        }
    }
}
