using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndAppenderStrategies
{
    public class MyCustomCollection
    {
        const int defaultSize = 100;
        string[] data = new string[defaultSize];
        int nrOfElements = 0;
        int resizeFactor = 1;

        private void IncreaseArraySize()
        {
            if(nrOfElements >= defaultSize)
            {
                resizeFactor++;
                Array.Resize(ref data, resizeFactor * defaultSize);
            }
        }

        public void Append(string element)
        {
            IncreaseArraySize();

            data[nrOfElements] = element;
            nrOfElements++;
        }

        public void Prepend(string element)
        {
            IncreaseArraySize();

            for(var i = nrOfElements; i > 0; i--)
            {
                data[i] = data[i - 1];
            }

            data[0] = element;
            nrOfElements++;
        }

        public void Clear()
        {
            Array.Resize(ref data, defaultSize);
            Array.Clear(data, 0, data.Length);
            nrOfElements = 0;
        }

        public int Count
        {
            get
            {
                return nrOfElements;
            }
        }

        public string First()
        {
            var element = data[0];

            for(var i = 0; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            
            data[data.Length - 1] = null;
            nrOfElements--;

            return element;
        }

        public string Last()
        {
            var element = data[nrOfElements - 1];

            data[nrOfElements - 1] = null;
            nrOfElements--;

            return element;
        }
    }
}
