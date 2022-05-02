namespace ProrobTest
{
    class SliderPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;
            this.UpdateProperty(markerCreator.actualSliderPosition.ToString());
        }
    }
}