using System;

namespace ProrobTest
{
    public class CustomTrackBar : System.Windows.Forms.TrackBar, IObserver
    {
        private delegate void _UpdateProperty(int maxValue);

        protected void UpdateProperty(int maxValue)
        {
            if (this.InvokeRequired)
            {
                //The update processing can be executed from another thread. 
                this.Invoke(new _UpdateProperty(UpdateProperty), new object[] { maxValue });
                return;
            }

            this.Maximum = maxValue;

        }

        public void Update(Observable observable, int e)
        {
            MarkerCreator markerCreator = (MarkerCreator)observable;

            this.UpdateProperty(markerCreator.maximumPosition);
        }
    }
}