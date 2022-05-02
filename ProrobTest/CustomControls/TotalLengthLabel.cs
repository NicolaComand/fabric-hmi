using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProrobTest.CustomControls
{
    class TotalLengthLabel : InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            int totalLength;

            if (markerCreator.markerList.Count != 0)
            {
                totalLength = markerCreator.markerList.Last().stopPosition - markerCreator.markerList.First().startPosition;
            }
            else
            {
                totalLength = 0;
            }           

            this.UpdateProperty(totalLength.ToString());

        }
    }
}
