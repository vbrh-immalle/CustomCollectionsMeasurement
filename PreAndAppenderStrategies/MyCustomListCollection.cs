using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    class MyCustomListCollection : MyCustomCollection
    {
        List<string> data = new List<string>();

        public override void Append(string element)
        {
            data.Add(element);
        }

        public override void Prepend(string element)
        {
            data.Insert(0, element);
        }

        public void Clear()
        {
            data.Clear();
        }

        public override int Count
        {
            get
            {
                return data.Count;
            }
        }

        public override string First()
        {
            var element = data[0];
            data.RemoveAt(0);
            return element;
        }

        public override string Last()
        {
            var element = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return element;
        }
    }
}
