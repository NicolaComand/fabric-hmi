namespace ProrobTest
{
    class DebugStateLabel : InfoLabel, IObserver
    {       
        public void Update(Observable from, int e)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            this.UpdateProperty(markerCreator.stato.ToString());

        }
    }
}