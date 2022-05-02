namespace ProrobTest
{
    class CurrentPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from, int e)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            this.UpdateProperty(markerCreator.currentPosition.ToString());
        }
    }
}
