using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Test
    {
        static void Main(string[] args)
        {
            Demo d = new Demo(45);

                d.fun();
        }
    }
}
