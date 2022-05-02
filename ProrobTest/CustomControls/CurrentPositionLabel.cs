namespace ProrobTest
{
    class CurrentPositionLabel : InfoLabel, IObserver
    {
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            this.UpdateProperty(markerCreator.CurrentPosition.ToString());
        }
    }
}
