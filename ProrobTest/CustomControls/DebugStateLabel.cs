namespace ProrobTest
{
    class DebugStateLabel : InfoLabel, IObserver
    {
        //public void Update(Observable from, CameraEvent e)
        public void Update(Observable from, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)from;

            this.UpdateProperty(markerCreator.stato.ToString());

        }
    }
}