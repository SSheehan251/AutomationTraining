﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolyMorphism
{
    class Sample
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.fun1();
            p.fun2();
        }
    }
}
