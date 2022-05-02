using System;
using System.Timers;

namespace ProrobTest
{
    public class WatchLabel : System.Windows.Forms.Label
    {
        private Timer timer = new Timer(1000);
        private delegate void _UpdateProperty(string infoText);

        public WatchLabel()
        {

            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        protected void UpdateProperty(string infoText)
        {
            if (this.InvokeRequired)
            {
                //The update processing can be executed from another thread. 
                this.Invoke(new _UpdateProperty(UpdateProperty), new object[] { infoText });
                return;
            }

            if (infoText != null)
            {
                this.Text = infoText;
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            UpdateProperty(DateTime.Now.ToString("h:mm:ss"));
        }
    }
}
