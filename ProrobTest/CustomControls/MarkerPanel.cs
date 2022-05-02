using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace ProrobTest
{
    class MarkerPanel : Panel, IObserver
    {
        private int maxPosition = 0;
        MarkerCreatorClass markerCreator = new MarkerCreatorClass();
        public MarkerPanel()
        {
            // Avoid Flickering
            this.DoubleBuffered = true;
        }

        public void Update(Observable from, int e)
        {
            markerCreator = (MarkerCreatorClass)from;
            maxPosition = markerCreator.maximumPosition;

            // Redraw control
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawCurrentMarkers(e);
            DrawCurrentBuildingMarker(e);            
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

        private void DrawCurrentBuildingMarker(PaintEventArgs e)
        {
            if (markerCreator.creatingMarker == null)
            {
                return;
            }            

            // Draw submarkers
            foreach (Marker subm in markerCreator.creatingMarker.subMarkers)
            {
                DrawRectangle(e, subm.startPosition, subm.stopPosition, 20, CustomColors.ShadedRed);

            }

            DrawCurrentStart(e);
            DrawCurrentSubMarkerStart(e);

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
            float horizontalScale = (float)this.Width / maxPosition;

            int panelHeight = this.Height;
            int verticalOffset = 10;

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
            

            SolidBrush brush = new SolidBrush(color);

            // Create rectangle.
            int width = stopPosition - startPosition;
            RectangleF rect = new RectangleF(horizontalScale * startPosition, verticalOffset, horizontalScale * width, panelHeight - 2 * verticalOffset);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(brush, rect);

        }

    }
}
