using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class Demo
    { 
        static void Main(string[] args)

    {
            Dictionary<string, object> d = new Dictionary<string, object>();

            d.Add("Employee Name", "Sinead Sheehan");
            d.Add("Employee Number", 40);
            d.Add("Employee Company", "Causeway");
            d.Add("Employee Phone", 0872998161);

            foreach (string key in d.Keys)
                Console.WriteLine(key + ":" + d[key]);

    }

    
    }
}
