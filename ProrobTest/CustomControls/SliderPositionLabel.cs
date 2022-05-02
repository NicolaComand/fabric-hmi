namespace ProrobTest
{
    class SliderPositionLabel : InfoLabel, IObserver
    {
        //public void Update(Observable from, CameraEvent e)
        public void Update(Observable from, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)from;

            this.UpdateProperty(markerCreator.actualSliderPosition.ToString());

            //CameraEvent.Type eventType = CameraEvent.Type.NONE;

            //if ((eventType = e.GetEventType()) == CameraEvent.Type.PROPERTY_CHANGED)
            //{
            //    uint propertyID = (uint)e.GetArg();

            //    if (propertyID == EDSDKLib.EDSDK.PropID_TempStatus)
            //    {
            //        //Update property
            //        switch (eventType)
            //        {
            //            case CameraEvent.Type.PROPERTY_CHANGED:
            //                CameraModel model = (CameraModel)from;
            //                var infoText = new string[] { "Normal", "Warning", "FramerateDown", "DisableLiveview", "DisableRelease", "StillQualityWarning", "RestrictionMovieRecording", "unknown" };

            //                if ((model.TempStatus & 0xffff0000) == 0x00020000)
            //                {
            //                    this.UpdateProperty(infoText[6]);
            //                }
            //                else
            //                {
            //                    if (infoText.Length > model.TempStatus)
            //                        this.UpdateProperty(infoText[model.TempStatus]);
            //                    else
            //                        this.UpdateProperty(infoText[infoText.Length - 1]);
            //                }
            //                break;
            //        }
            //    }
            //}
        }
    }
}