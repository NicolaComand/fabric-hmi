using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class NSplicesLabel: InfoLabel,IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)from;

            if (markerCreator.creatingMarker != null)
            {
                this.UpdateProperty(markerCreator.creatingMarker.subMarkers.Count().ToString());
            }
            else
            {
                this.UpdateProperty("0");
            }           

        }
    }
}
