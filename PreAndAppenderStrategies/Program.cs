using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    class Program
    {
        static void Main(string[] args)
        {
            var coll = new MyCustomCollection();

            coll.Append("How are you?");
            coll.Prepend("Hello!");
            coll.Append("I'm fine, thank you!");

            Console.WriteLine(coll.First()); // take 1th element and remove it
            Console.WriteLine(coll.First());
            Console.WriteLine(coll.Last()); // only 1 element left, doesn't matter which method we use
        }
    }
}
