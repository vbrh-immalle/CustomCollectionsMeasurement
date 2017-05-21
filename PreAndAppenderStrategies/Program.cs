using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    class Program
    {

        struct Measurement
        {
            public TimeSpan Append;
            public TimeSpan Prepend;
            public TimeSpan First;
            public TimeSpan Last;

            public override string ToString()
            {
                var str = "Append: " + Append.ToString() + Environment.NewLine;
                str += "Prepend: " + Prepend.ToString() + Environment.NewLine;
                str += "First: " + First.ToString() + Environment.NewLine;
                str += "Last: " + Last.ToString() + Environment.NewLine;

                return str;
            }
        }

        static void Main(string[] args)
        {
            const int times = 2000;
    
            DateTime before;
            DateTime after;

            Measurement arrayMeasurement = new Measurement();
           // Measurement listMeasurement;

            var coll = new MyCustomArrayCollection();

            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                coll.Append(i.ToString());
            }
            after = DateTime.Now;
            arrayMeasurement.Append = after - before;

            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                var _ = coll.First();
            }
            after = DateTime.Now;
            arrayMeasurement.First = after - before;

            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                coll.Prepend(i.ToString());
            }
            after = DateTime.Now;
            arrayMeasurement.Prepend = after - before;
            
            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                var _ = coll.Last();
            }
            after = DateTime.Now;
            arrayMeasurement.Prepend = after - before;


            Console.WriteLine(arrayMeasurement.ToString());
        }
    }
}
