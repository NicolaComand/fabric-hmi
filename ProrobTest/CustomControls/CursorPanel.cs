using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace ProrobTest
{
    class CursorPanel : Panel, IObserver
    {
        private int maxPosition = 0;

        MarkerCreatorClass markerCreator = new MarkerCreatorClass();
        public CursorPanel()
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
            DrawStartCursor(e);
            DrawCurrentCursor(e);
        }

        private void DrawStartCursor(PaintEventArgs e)
        {
            if (markerCreator.markerList.Count() == 0)
            {
                return;
            }

            int startPosition = markerCreator.markerList.Min(m => m.startPosition);
            DrawTriangle(e, startPosition, Color.Green);

        }

        private void DrawCurrentCursor(PaintEventArgs e)
        {
            DrawTriangle(e, markerCreator.actualSliderPosition, Color.Red);
        }

        private void DrawTriangle(PaintEventArgs e, int position, Color color)
        {

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

            SolidBrush redBrush = new SolidBrush(color);
            e.Graphics.FillPolygon(redBrush, curvePoints);
        }     

    }
}
