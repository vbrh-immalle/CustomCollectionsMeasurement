using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    public abstract class MyCustomCollection
    {
        public abstract void Append(string element);
        public abstract void Prepend(string element);

        public abstract int Count { get; }

        public abstract string First();
        public abstract string Last();
    }

}
