using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProrobTest.CustomControls
{
    class TotalLengthLabel : InfoLabel, IObserver
    {
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            int totalLength;

            if (markerCreator.MarkerList.Count != 0)
            {
                totalLength = markerCreator.MarkerList.Last().stopPosition - markerCreator.MarkerList.First().startPosition;
            }
            else
            {
                totalLength = 0;
            }           

            this.UpdateProperty(totalLength.ToString());

        }
    }
}
