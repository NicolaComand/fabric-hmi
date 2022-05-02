namespace ProrobTest
{
    class CurrentPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)from;

            this.UpdateProperty(markerCreator.currentPosition.ToString());
        }
    }
}
