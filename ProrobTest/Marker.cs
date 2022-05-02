using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest
{
    class Marker
    {
        public int index = -1;
        public int startPosition = 0;
        public int stopPosition = 0;
        public int offset = 0;

        public List<Marker> subMarkers = new List<Marker>();

        public Marker()
        {

        }
        public Marker(int start, int stop)
        {
            startPosition = start;
            stopPosition = stop;
        }     

    }

}

