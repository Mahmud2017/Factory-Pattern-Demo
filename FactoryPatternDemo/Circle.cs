﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemo
{
    class Circle : Shape
    {
        public void Print()
        {
            Console.WriteLine("I am a circle.");
        }
    }
}
