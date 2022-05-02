using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrobTest
{
 
    class CustomButton : System.Windows.Forms.Button
    {
        private delegate void _UpdateProperty(bool isEnabled);

        protected void UpdateProperty(bool isEnabled)
        {
            if (this.InvokeRequired)
            {
                //The update processing can be executed from another thread. 
                this.Invoke(new _UpdateProperty(UpdateProperty), new object[] { isEnabled });
                return;
            }

            this.Enabled = isEnabled;
        }

        
    }
}
