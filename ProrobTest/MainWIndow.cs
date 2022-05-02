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
        List<IObserver> _observerList = new List<IObserver>();
        MarkerCreatorClass MarkerCreator;        

        public MainWIndow()
        {         
            InitializeComponent();
            InitializeMarkerCreator();
        }

        public void InitializeMarkerCreator()
        {
            MarkerCreator = new MarkerCreatorClass(customTrackBar.Value);

            // Add Observers
            _observerList.Add(sliderPositionLabel);
            _observerList.Add(sliderPositionLabel1);
            _observerList.Add(currentPositionLabel);
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
            _observerList.Add(nMarkerLabel);
            _observerList.Add(nSplicesLabel);
            _observerList.Add(totalLengthLabel);
            _observerList.Add(markersLength1);

            _observerList.ForEach(observer => MarkerCreator.Add(ref observer));

            // Do first update
            MarkerCreator.NotifyObservers(0);
        }

        private void sliderSetPosition_Scroll(object sender, EventArgs e)
        {
            MarkerCreator.ActualSliderPosition = ((System.Windows.Forms.TrackBar)sender).Value;
        }

        private void buttonAperturaMarcatore_Click(object sender, EventArgs e)
        {
            MarkerCreator.OpenMarker();
        }

        private void buttonChiusuraMarcatore_Click(object sender, EventArgs e)
        {
            MarkerCreator.CloseMarker();
        }

        private void buttonAperturaSottoMarcatore_Click(object sender, EventArgs e)
        {
            MarkerCreator.OpenSubMarker();
        }

        private void buttonChiusuraSottoMarcatore_Click(object sender, EventArgs e)
        {
            MarkerCreator.CloseSubMarker();
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.InitializeMarkerCreator();            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ExportToJson();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ExportToJson()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "Ricetta.json";
            saveDialog.Filter = "Text File | *.json";

            if (saveDialog.ShowDialog() == DialogResult.OK && saveDialog.FileName != "")
            {

                StreamWriter writer = new StreamWriter(saveDialog.OpenFile());

                List<ExportMarker> exportList = new List<ExportMarker>();

                foreach (Marker m in MarkerCreator.MarkerList)
                {
                    exportList.Add(new ExportMarker(m));
                }

                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(exportList, options);


                writer.WriteLine(jsonString);

                writer.Dispose();
                writer.Close();

            }
        }

    }
}
