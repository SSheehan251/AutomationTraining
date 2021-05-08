using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethodsWithReturnType
{
    public class Sample
    {
        static int i = 40;
        static string s = "Sinead";

        public static int function1()
        {
            return i;
        }

        public static string function2()
        {
            return s;
        }
    }
}
