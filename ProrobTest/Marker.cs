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


        public string createJsonDescription()
        {
            string jsonString = "";

            jsonString += "{\n";
            jsonString += "\"Index\":" + index.ToString() + ",\n";
            jsonString += "\"Offset\":" + offset.ToString() + ",\n";  // TODO
            jsonString += "\"Start\":" + startPosition.ToString() + ",\n";
            jsonString += "\"Stop\":" + stopPosition.ToString() + ",\n";
            jsonString += "\"Splices\": [";

            foreach (Marker subm in subMarkers)
            {
                jsonString += "\n{\n";
                jsonString += "\"MarkerIndex\":" + index.ToString() + ",\n";
                jsonString += "\"Start\":" + subm.startPosition.ToString() + ",\n";
                jsonString += "\"Stop\":" + subm.stopPosition.ToString() + "\n";
                jsonString += "}\n";

                //if (subm.index = subMarkers.Count - 1)
                //{

                //} 
            }

            jsonString += "]\n";
            jsonString += "}\n";

            return jsonString;
        }


    }

}

