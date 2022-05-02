using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class NSplicesLabel: InfoLabel,IObserver
    {
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            if (markerCreator.CreatingMarker != null)
            {
                this.UpdateProperty(markerCreator.CreatingMarker.subMarkers.Count().ToString());
            }
            else
            {
                this.UpdateProperty("0");
            }           

        }
    }
}
