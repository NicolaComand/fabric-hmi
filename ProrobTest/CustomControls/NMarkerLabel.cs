using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class NMarkerLabel: InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            this.UpdateProperty(markerCreator.markerList.Count().ToString());
        }
    }
}
