﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASE_Assignment_2020
{
    class Rectangle : Shape
    {
        public void drawShape(string[] res, Graphics g, int a, int b)
        {
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[2]);
            Pen p = new Pen(Color.Black, 5);
            g.DrawRectangle(p, a, b, c, d);
        }
    }
}
