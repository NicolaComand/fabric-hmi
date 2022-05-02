using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class OpenMarkerButton : CustomButton, IObserver
    {
        public void Update(Observable observable, int e)
        {
            bool enabled = false;
            MarkerCreator markerCreator = (MarkerCreator)observable;


            switch (markerCreator.stato)
            {
                case MarkerCreator.State.IDLE:
                    enabled = true;
                    break;
                case MarkerCreator.State.MARKER_NOT_VALID:
                    break;
                case MarkerCreator.State.MARKER_VALID:
                    break;
                case MarkerCreator.State.IDLE_NOT_FIRST_MARKER:
                    break;
                case MarkerCreator.State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:
                    break;
                case MarkerCreator.State.SUB_MARKER_ENABLE_START:
                    break;
                case MarkerCreator.State.SUB_MARKER_INVALID:
                    break;
                case MarkerCreator.State.SUB_MARKER_VALID:
                    break;
                case MarkerCreator.State.SUB_MARKER_CLOSED:
                    break;
                case MarkerCreator.State.VALID_MARKER_WITH_SUBMARKERS:
                    break;
                case MarkerCreator.State.INVALID_MARKER_WITH_SUBMARKERS:
                    break;
                default:
                    break;
            }

            this.UpdateProperty(enabled);
        }

    }
}
