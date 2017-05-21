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


        static Measurement MeasureCustomCollection(MyCustomCollection collection)
        {
            Measurement m = new Measurement();
            const int times = 5000;

            DateTime before;
            DateTime after;

            // measure Append
            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                collection.Append(i.ToString());
            }
            after = DateTime.Now;
            m.Append = after - before;

            // measure First
            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                var _ = collection.First();
            }
            after = DateTime.Now;
            m.First = after - before;

            // measure Prepend
            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                collection.Prepend(i.ToString());
            }
            after = DateTime.Now;
            m.Prepend = after - before;
            
            // measure Last
            before = DateTime.Now;
            for(var i = 0; i < times; i++)
            {
                var _ = collection.Last();
            }
            after = DateTime.Now;
            m.Prepend = after - before;

            return m;
        }


        static void Main(string[] args)
        {
            var arrayColl = new MyCustomArrayCollection();
            var listColl = new MyCustomListCollection();

            Console.WriteLine("Measuring array collection...");
            Console.WriteLine(MeasureCustomCollection(arrayColl));

            Console.WriteLine("Measuring list collection...");
            Console.WriteLine(MeasureCustomCollection(listColl));
        }
    }
}
