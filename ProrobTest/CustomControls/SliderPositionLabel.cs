namespace ProrobTest
{
    class SliderPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)from;
            this.UpdateProperty(markerCreator.actualSliderPosition.ToString());
        }
    }
}