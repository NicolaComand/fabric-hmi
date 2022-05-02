namespace ProrobTest
{
    class DebugStateLabel : InfoLabel, IObserver
    {       
        public void Update(Observable from)
        {
            MarkerCreatorClass markerCreator = (MarkerCreatorClass)from;

            this.UpdateProperty(markerCreator.Stato.ToString());

        }
    }
}