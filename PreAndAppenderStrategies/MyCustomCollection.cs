using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    class MyCustomCollection
    {
        List<string> data = new List<string>();

        public void Append(string element)
        {
            data.Add(element);
        }

        public void Prepend(string element)
        {
            data.Insert(0, element);
        }

        public void Clear()
        {
            data.Clear();
        }

        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        public string First()
        {
            var element = data[0];
            data.RemoveAt(0);
            return element;
        }

        public string Last()
        {
            var element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }
    }
}
