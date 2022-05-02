using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace ProrobTest
{
    public partial class MainWIndow : Form
    {
        List<Marker> markerList = new List<Marker>();
        MarkerCreator markerCreator;

        List<IObserver> _observerList = new List<IObserver>();

        public MainWIndow()      {
            

            InitializeComponent();
            InitializeMarkerCreator();


        }

        public void InitializeMarkerCreator()
        {
            markerCreator = new MarkerCreator(customTrackBar.Value);
            // Add Observers

            _observerList.Add(sliderPositionLabel);
            _observerList.Add(cursorPanel);
            _observerList.Add(markerPanel);
            _observerList.Add(debugStateLabel);

            _observerList.Add(openMarkerButton);
            _observerList.Add(openSubMarkerButton);
            _observerList.Add(closeSubMarkerButton);
            _observerList.Add(closeMarkerButton);
            _observerList.Add(confirmButton);
            _observerList.Add(annullaButton);
            _observerList.Add(customTrackBar);






            _observerList.ForEach(observer => markerCreator.Add(ref observer));
            markerCreator.NotifyObservers(0);
        }



        private void sliderSetPosition_Scroll(object sender, EventArgs e)
        {
            // Set the scroll value in the marker generator class
            markerCreator.actualSliderPosition = ((System.Windows.Forms.TrackBar)sender).Value;
            //pictureBox1.Invoke((MethodInvoker)delegate { pictureBox1.Refresh(); });
        }

        private void buttonAperturaMarcatore_Click(object sender, EventArgs e)
        {
            markerCreator.OpenMarker();
        }

        private void buttonChiusuraMarcatore_Click(object sender, EventArgs e)
        {
            markerCreator.CloseMarker();
        }

        private void buttonAperturaSottoMarcatore_Click(object sender, EventArgs e)
        {
            markerCreator.OpenSubMarker();
        }

        private void buttonChiusuraSottoMarcatore_Click(object sender, EventArgs e)
        {
            markerCreator.CloseSubMarker();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.InitializeMarkerCreator();
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {


            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Title = "Save an Image File";
            //saveFileDialog1.ShowDialog();


            //// If the file name is not an empty string open it for saving.
            //if (saveFileDialog1.FileName != "")
            //{
            //    // Saves the Image via a FileStream created by the OpenFile method.
            //    System.IO.FileStream fs =
            //        (System.IO.FileStream)saveFileDialog1.OpenFile();
            //    // Saves the Image in the appropriate ImageFormat based upon the
            //    // File type selected in the dialog box.
            //    // NOTE that the FilterIndex property is one-based.
            //    //switch (saveFileDialog1.FilterIndex)
            //    //{
            //    //    case 1:
            //    //        this.button2.Image.Save(fs,
            //    //          System.Drawing.Imaging.ImageFormat.Jpeg);
            //    //        break;

            //    //    case 2:
            //    //        this.button2.Image.Save(fs,
            //    //          System.Drawing.Imaging.ImageFormat.Bmp);
            //    //        break;

            //    //    case 3:
            //    //        this.button2.Image.Save(fs,
            //    //          System.Drawing.Imaging.ImageFormat.Gif);
            //    //        break;
            //    //}

            //    fs.Close();



                SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "Rocetta.json";

            saveDialog.Filter = "Text File | *.json";

                if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName != "")

                {

                    StreamWriter writer = new StreamWriter(saveDialog.OpenFile());

                    string jsonString = "";

                    foreach (Marker m in markerCreator.markerList)
                    {
                        jsonString += m.createJsonDescription();
                    }

                    writer.WriteLine(jsonString);

                    writer.Dispose();

                    writer.Close();

                }



        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        //public void Prova()
        //{
        //    //Product product = new Product();
        //    //product.ExpiryDate = new DateTime(2008, 12, 28);

        //    JsonSerializer serializer = new JsonSerializer();
        //    serializer.Converters.Add(new JavaScriptDateTimeConverter());
        //    serializer.NullValueHandling = NullValueHandling.Ignore;

        //    using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
        //    using (JsonWriter writer = new JsonTextWriter(sw))
        //    {
        //        serializer.Serialize(writer, product);
        //    }
        //}


    }
}
