using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Graphs
{
    internal class PieChartControl : Control
    {
        private List<float> _values = new List<float>();
        private List<Color> _sliceColors = new List<Color>
        {
            Color.Red, Color.Green, Color.Blue, Color.LightCoral, Color.Brown, Color.Beige, Color.Purple, Color.Black, Color.White, Color.Orange, Color.DimGray, Color.Yellow
        };

        public PieChartControl()
        {
            this.DoubleBuffered = true; // Helps reduce flickering
            SetValues(new List<float> { 10, 20, 30 }); // Set default values for testing
        }

        public void SetValues(List<float> values)
        {
            _values = values ?? new List<float>();
            Invalidate(); // Causes the control to be redrawn
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode) return;
            base.OnPaint(e);

            if (_values == null || _values.Count == 0)
            {
                e.Graphics.DrawString("No data", this.Font, Brushes.Black, new PointF(10, 10));
                return;
            }

            DrawPieChart(e.Graphics);
        }

        private void DrawPieChart(Graphics graphics)
        {
            float total = _values.Sum();
            float startAngle = 0f;
            var bounds = new Rectangle(10, 10, Width - 20, Height - 20);

            for (int i = 0; i < _values.Count; i++)
            {
                float sweepAngle = (_values[i] / total) * 360f;
                using (Brush brush = new SolidBrush(_sliceColors[i % _sliceColors.Count]))
                {
                    graphics.FillPie(brush, bounds, startAngle, sweepAngle);
                }
                startAngle += sweepAngle;
            }
        }
    }
}