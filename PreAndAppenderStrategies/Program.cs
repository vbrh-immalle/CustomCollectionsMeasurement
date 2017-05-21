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
            var list = new System.Collections.Generic.List<string>();

            list.Add("FIFO, LIFO, FILO or LILO?"); // Enqueue
            list.Add("With a List or array ..."); // Enqueue
            list.Add("... we can choose!"); // Enqueue

            // do a 'Peek'
            Console.WriteLine(list[0]);

            // count
            Console.WriteLine(list.Count);

            // do a 'Dequeue'
            Console.WriteLine(list[list.Count - 1]);
            list.RemoveAt(list.Count - 1);

            // do a 'Pop'
            Console.WriteLine(list[0]);
            list.RemoveAt(0);

            Console.WriteLine(list.Count); // 1 left
        }
    }
}
