using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart.NET
{
    public partial class Chart : UserControl
    {

        Graphics graphics;
        private int _Height = 0;
        private int _Widht = 0;
        private int StartX = 0;
        private int StartY = 0;
        List<Tuple<int, int>> Data;

        public Color Chart_RectBackground { get; set; } = Color.Gray;
        public Color Chart_RectBorderColor { get; set; } = Color.White;
        public Color Chart_AxeForegorund { get; set; } = Color.Black;
        public Color Chart_AxeBorderColor { get; set; } = Color.Black;
        public int Chart_AxeFontSize { get; set; } = 11;
        public string Chart_AxeY { get; set; } = "Y";
        public string Chart_AxeX { get; set; } = "X";

        public Chart()
        {
            InitializeComponent();
        }

        public Chart(List<Tuple<int, int>> _Data)
        {
            Data = _Data;
            this.Invalidate();
            this.Paint += new PaintEventHandler(this.Canvas_Paint);
            this.Dock = DockStyle.Fill;
        }

        private void CreateAxes(Graphics graphics)
        {
            _Height = this.Height - this.Margin.Bottom;
            _Widht = this.Width - this.Margin.Left;
            StartX = this.Margin.Left;
            StartY = this.Margin.Bottom;
            graphics.DrawString(Chart_AxeY, new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(StartX, StartY));
            graphics.DrawString(Chart_AxeX, new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(_Widht-20, _Height- 20));
            graphics.DrawString("0", new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(StartX, _Height));
            graphics.DrawLine(new Pen(Chart_AxeBorderColor), new Point(StartX, StartY), new Point(StartX, _Height));
            graphics.DrawLine(new Pen(Chart_AxeBorderColor), new Point(StartX, _Height), new Point(_Widht, _Height));
        }

        private void plot(List<Tuple<int,int>> Data)
        {
            //to avoid dividing by zero
            try
            {
                var widht_unit = (Width - (StartX * 2)) / Data.Count - 1;
                var height_unit = (_Height - StartY) / Data.Count - 1;
                foreach (var point in Data)
                {
                    var height = point.Item2 * height_unit;
                    var widht = widht_unit;
                    DrawRectangle(height, widht, StartX + (point.Item1 - 1) * widht, _Height - height);
                }
            }
            catch
            {

            }
        }

        private void DrawRectangle(int RectangleHeight, int RectangleWidth, int RectX, int RectY)
        {
            var r = new Rectangle()
            {
                Height = RectangleHeight,
                Width = RectangleWidth,
                X = RectX,
                Y = RectY
            };
            Pen pen = new Pen(new SolidBrush(Chart_RectBorderColor));
            graphics.FillRectangle(new SolidBrush(Chart_RectBackground), r);
            graphics.DrawRectangle(pen, r);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            CreateAxes(graphics);
            plot(Data);
        }
    }
}
