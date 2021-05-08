using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    public class Demo
    {

        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a.Add("Sinead");
            a.Add("Sheehan");
            a.Add("Conor");
            a.Add("Sheehan");
            a.Add("Currans");
            a.Add("Killarney");
            a.Add("Kerry");

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
