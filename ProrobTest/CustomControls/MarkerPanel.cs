using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace ProrobTest
{
    class MarkerPanel : Panel, IObserver
    {
 
        MarkerCreator markerCreator = new MarkerCreator();
        public MarkerPanel()
        {
            // Avoid Flickering
            this.DoubleBuffered = true;
        }

        //public void Update(Observable from, CameraEvent e)
        public void Update(Observable from, int e)
        {
            markerCreator = (MarkerCreator)from;

            // Redraw control
            this.Invalidate();

        }

        //this.UpdateProperty(markerCreator.actualSliderPosition.ToString());


        protected override void OnPaint(PaintEventArgs e)
        {

            //DrawStartCursor(e);
            //DrawCurrentCursor(e);

            DrawCurrentMarkers(e);
            DrawCurrentBuildingMarker(e);


            
            DrawCurrentSubMarkerStart(e);

        }

        private void DrawCurrentBuildingMarker(PaintEventArgs e)
        {
            if (markerCreator.creatingMarker == null)
            {
                return;
            }

            DrawCurrentStart(e);

            // Draw submarkers
            foreach (Marker subm in markerCreator.creatingMarker.subMarkers)
            {
                DrawRectangle(e, subm.startPosition, subm.stopPosition, 20, CustomColors.ShadedRed);

            }

            DrawCurrentSubMarkerStart(e);


        }


        private void DrawCurrentMarkers(PaintEventArgs e)
        {
            foreach (Marker m in markerCreator.markerList)
            {
                DrawRectangle(e, m.startPosition, m.stopPosition);
                foreach (Marker subm in m.subMarkers)
                {
                    DrawRectangle(e, subm.startPosition, subm.stopPosition, 20, CustomColors.ShadedRed);
                }

            }
        }

        public void DrawCurrentStart(PaintEventArgs e)
        {
            if (markerCreator.creatingMarker != null)
            {                
                DrawLine(e, markerCreator.creatingMarker.startPosition, 3);
            }
        }

        private void DrawCurrentSubMarkerStart(PaintEventArgs e)
        {
            if (markerCreator.creatingSubMarker != null)
            {
                DrawLine(e, markerCreator.creatingSubMarker.startPosition, 1);
            }
      }



        public void DrawLine(PaintEventArgs e, int position, int penThickness)
        {

            int maxPosition = 4000; //TODO: no hardcoded
            float horizontalScale = (float)this.Width / maxPosition;

            Pen pen = new Pen(Color.Green, penThickness);

            // Create points that define line.
            PointF point1 = new PointF(horizontalScale* position, 0);
            PointF point2 = new PointF(horizontalScale* position, this.Height);

            // Draw line to screen.
            e.Graphics.DrawLine(pen, point1, point2);

        }

        public void DrawRectangle(PaintEventArgs e, int startPosition, int stopPosition)
        {
            int maxPosition = 4000; //TODO: no hardcoded
            float horizontalScale = (float)this.Width / maxPosition;


            int panelHeight = this.Height;

            int verticalOffset = 10;

            // STATO: colore pennello
            SolidBrush brush = new SolidBrush(CustomColors.ShadedBlue);

            // Create rectangle.

            int width = stopPosition - startPosition;
            
            RectangleF rect = new RectangleF(horizontalScale * startPosition, verticalOffset , horizontalScale * width, panelHeight - 2 * verticalOffset);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(brush, rect);

        }

        public void DrawRectangle(PaintEventArgs e, int startPosition, int stopPosition, int verticalOffset, Color color)
        {
            int maxPosition = 4000; //TODO: no hardcoded
            float horizontalScale = (float)this.Width / maxPosition;


            int panelHeight = this.Height;

            
            // STATO: colore pennello
            SolidBrush brush = new SolidBrush(color);

            // Create rectangle.

            int width = stopPosition - startPosition;

            RectangleF rect = new RectangleF(horizontalScale * startPosition, verticalOffset, horizontalScale * width, panelHeight - 2 * verticalOffset);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(brush, rect);

        }





        private void DrawStartCursor(PaintEventArgs e)
        {
            if (markerCreator.markerList.Count() == 0)
            {
                return;
            }

            // TODO: CAPIRE COSA FA CON LISTA VUOTA
            int startPosition = markerCreator.markerList.Min(m => m.startPosition);

            DrawTriangle(e, startPosition, Color.Green);

        }

        private void DrawCurrentCursor(PaintEventArgs e)
        {

            DrawTriangle(e, markerCreator.actualSliderPosition, Color.Red);

        }



        private void DrawTriangle(PaintEventArgs e, int position, Color color)
        {

            int maxPosition = 4000; //TODO: no hardcoded
            float horizontalScale = (float)this.Width / maxPosition;


            int panelHeight = this.Height;
            float markerWidth = panelHeight;

            // Draw triangle
            PointF point1 = new PointF(horizontalScale * position - markerWidth / 2, 0);
            PointF point2 = new PointF(horizontalScale * position + markerWidth / 2, 0);
            PointF point3 = new PointF(horizontalScale * position, panelHeight);

            PointF[] curvePoints =
             {
                 point1,
                 point2,
                 point3
            };

            // STATO: colore pennello
            SolidBrush redBrush = new SolidBrush(color);
            e.Graphics.FillPolygon(redBrush, curvePoints);
        }






        //Panel p = this;
        ////Graphics g = p.CreateGraphics();
        //Graphics g = e.Graphics;
        //Pen pen = new Pen(Color.Black, 3);
        //g.DrawRectangle(pen, 10, 0, 50, p.Height);
        //    SolidBrush redBrush = new SolidBrush(Color.Red);
        ////g.FillRectangle(redBrush, 0, 0, 20, 40);
        //g.DrawString(this.GetType().Name + " ", SystemFonts.DefaultFont, redBrush, 80, p.Height / 2);
        //CameraEvent.Type eventType = CameraEvent.Type.NONE;

        //if ((eventType = e.GetEventType()) == CameraEvent.Type.PROPERTY_CHANGED)
        //{
        //    uint propertyID = (uint)e.GetArg();

        //    if (propertyID == EDSDKLib.EDSDK.PropID_TempStatus)
        //    {
        //        //Update property
        //        switch (eventType)
        //        {
        //            case CameraEvent.Type.PROPERTY_CHANGED:
        //                CameraModel model = (CameraModel)from;
        //                var infoText = new string[] { "Normal", "Warning", "FramerateDown", "DisableLiveview", "DisableRelease", "StillQualityWarning", "RestrictionMovieRecording", "unknown" };

        //                if ((model.TempStatus & 0xffff0000) == 0x00020000)
        //                {
        //                    this.UpdateProperty(infoText[6]);
        //                }
        //                else
        //                {
        //                    if (infoText.Length > model.TempStatus)
        //                        this.UpdateProperty(infoText[model.TempStatus]);
        //                    else
        //                        this.UpdateProperty(infoText[infoText.Length - 1]);
        //                }
        //                break;
        //        }
        //    }
        //}

    }
}
