namespace ProrobTest
{
    class SliderPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;
            this.UpdateProperty(markerCreator.ActualSliderPosition.ToString());
        }
    }
}