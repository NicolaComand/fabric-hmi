using System;


namespace ProrobTest.CustomControls
{
    class OpenMarkerButton : CustomButton, IObserver
    {
        public void Update(Observable observable, int e)
        {
            bool enabled = false;
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)observable;

            switch (markerCreator.stato)
            {
                case MarkerCreatorClass.State.IDLE:
                    enabled = true;
                    break;
                case MarkerCreatorClass.State.MARKER_NOT_VALID:
                    break;
                case MarkerCreatorClass.State.MARKER_VALID:
                    enabled = true;
                    break;
                case MarkerCreatorClass.State.IDLE_NOT_FIRST_MARKER:
                    break;
                case MarkerCreatorClass.State.IDLE_NOTE_FIRST_MARKER_START_ENABLED:
                    enabled = true;
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
