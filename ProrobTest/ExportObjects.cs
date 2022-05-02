using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest
{
    class ExportMarker
    {
        public int Index { get; set; }
        public int Offset{ get; set; }
        public int Start { get; set; }
        public int Stop { get; set; }
        public List<ExportSubMarker> Splices { get; set; } = new List<ExportSubMarker>();
        public ExportMarker(Marker marker)
        {
            Index = marker.index;
            Offset = marker.offset;
            Start = marker.startPosition;
            Stop = marker.stopPosition;

            foreach (Marker subm in marker.subMarkers)
            {
                Splices.Add(new ExportSubMarker(subm));
            }
        }
    }


    class ExportSubMarker
    {
        public int MarkerIndex { get; set; }
        public int Start { get; set; }
        public int Stop { get; set; }

        public ExportSubMarker(Marker submarker)
        {
            MarkerIndex = submarker.index;
            Start = submarker.startPosition;
            Stop = submarker.stopPosition;
        }       
       
    }
}
