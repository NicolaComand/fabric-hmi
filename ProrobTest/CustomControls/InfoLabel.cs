
using System;

namespace ProrobTest
{
    public class InfoLabel : System.Windows.Forms.Label
    {
        private delegate void _UpdateProperty(string infoText);

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

    }
}

