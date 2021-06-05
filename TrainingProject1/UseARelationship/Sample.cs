using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseARelationship
{
    public class Sample
    {
        static void Main(string[] args)
        {
            Demo1 dd = new Demo1();
            Demo2 c = new Demo2();
            c.fun3(dd);

               
        }
    }
}
