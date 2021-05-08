using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList123
{
    public class Demo
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add("Sinead");
            a.Add("Sheehan");
            a.Add(40);
            a.Add(true);
            a.Add(34.5f);

            foreach (var i in a)



                Console.WriteLine(i);
        }
    }
}
