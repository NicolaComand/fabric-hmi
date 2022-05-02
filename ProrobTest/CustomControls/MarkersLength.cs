using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class MarkersLength: InfoLabel, IObserver
    {
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            int markersLength = markerCreator.MarkerList.Sum(m => m.stopPosition - m.startPosition);

            this.UpdateProperty(markersLength.ToString());

        }
    }
}
