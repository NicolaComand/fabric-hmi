using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest.CustomControls
{
    class AnnullaButton : CustomButton, IObserver
    {
        public void Update(Observable observable)
        {
            bool enabled = true;
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)observable;

            switch (markerCreator.Stato)
            {
                case MarkerCreatorClass.State.IDLE:
                    break;
                case MarkerCreatorClass.State.MARKER_NOT_VALID:
                    break;
                case MarkerCreatorClass.State.MARKER_VALID:
                    break;
                case MarkerCreatorClass.State.IDLE_NOT_FIRST_MARKER:
                    break;
                case MarkerCreatorClass.State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:
                    break;
                case MarkerCreatorClass.State.SUB_MARKER_ENABLE_START:
                    break;
                case MarkerCreatorClass.State.SUB_MARKER_INVALID:
                    break;
                case MarkerCreatorClass.State.SUB_MARKER_VALID:
                    break;
                case MarkerCreatorClass.State.SUB_MARKER_CLOSED:
                    break;
                case MarkerCreatorClass.State.VALID_MARKER_WITH_SUBMARKERS:
                    break;
                case MarkerCreatorClass.State.INVALID_MARKER_WITH_SUBMARKERS:
                    break;
                default:
                    break;
            }

            this.UpdateProperty(enabled);
        }

    }
}
