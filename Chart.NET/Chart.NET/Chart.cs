﻿using System;
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
        List<int> XData;
        List<int> YData;
        private int minX = 0;
        private int maxX = 0;
        private int minY = 0;
        private int maxY = 0;

        private int widht_unit = 0;
        private int height_unit = 0;
        public Color Chart_RectBackground { get; set; } = Color.Gray;
        public Color Chart_RectBorderColor { get; set; } = Color.White;
        public Color Chart_AxeForegorund { get; set; } = Color.Black;
        public Color Chart_AxeBorderColor { get; set; } = Color.Black;
        public Color Chart_BorderedColor { get; set; } = Color.Gray;
        public int Chart_AxeFontSize { get; set; } = 11;
        public string Chart_AxeY { get; set; } = "Y";
        public string Chart_AxeX { get; set; } = "X";
        public bool Chart_IsBordered { get; set; } = false;
        private int NbRect { get; set; } = 0;

        public Chart()
        {
            //InitializeComponent();
            this.Margin = new Padding(30,30,30,30);
            minX = XData.Min();
            maxX = XData.Max();
            minY = YData.Min();
            maxY = YData.Max();
            Data = MapData(XData, YData);
            this.Invalidate();
            this.Paint += new PaintEventHandler(this.Canvas_Paint);
            this.Dock = DockStyle.Fill;
        }

        public Chart(List<int> _XData, List<int> _YData)
        {
            //InitializeComponent();
            this.Margin = new Padding(50, 50, 50, 50);
            XData = _XData;
            YData = _YData;
            minX = XData.Min();
            maxX = XData.Max();
            minY = YData.Min();
            maxY = YData.Max();
            Data = MapData(XData, YData);
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
            graphics.DrawString(Chart_AxeY, new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(0, StartY));
            graphics.DrawString(Chart_AxeX, new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(_Widht +StartX/2, _Height  ));
            graphics.DrawString("0", new Font(FontFamily.GenericSerif, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Chart_AxeForegorund), new Point(0, _Height));
            graphics.DrawLine(new Pen(Chart_AxeBorderColor), new Point(StartX, StartY), new Point(StartX, _Height));
            graphics.DrawLine(new Pen(Chart_AxeBorderColor), new Point(StartX, _Height), new Point(_Widht, _Height));
        }

        List<Tuple<int, int>> MapData(List<int> XData, List<int> YData)
        {
            List<Tuple<int, int>> Data = new List<Tuple<int, int>>();

            for (int i = 0; i < XData.Count; i++)
            {
                Data.Add(new Tuple<int, int>(XData[i] - minX + 1, YData[i]));
            }
            return Data;
        }

        private void plot(List<Tuple<int, int>> Data)
        {
            //to avoid dividing by zero
            try
            {
                widht_unit = (Width - StartX) / (maxX - minX + 1);
                height_unit = (_Height - StartY) / (maxY-minY +1);
                foreach (var point in Data)
                {
                    var height = (point.Item2 - minY +1) * height_unit ;
                    var widht = widht_unit;
                    DrawRectangle(height, widht, StartX + (point.Item1 - 1) * widht, _Height - height);
                }

                if (Chart_IsBordered)
                {
                    foreach (var point in Data)
                    {
                        var height = (point.Item2 - minY +1) * height_unit;
                        var widht = widht_unit;
                        DrawBorders(height, widht, StartX + (point.Item1 - 1) * widht, _Height - height);
                    }
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
            NbRect++;
        }

        private void DrawBorders(int RectangleHeight, int RectangleWidth, int RectX, int RectY)
        {
            StringFormat drawFormat = new StringFormat();
            if (NbRect>20)
             drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            Pen DashedPen = new Pen(Chart_BorderedColor, 1);
            DashedPen.DashPattern = new float[] { 3, 3, 3, 3 };
            graphics.DrawLine(DashedPen, new Point(StartX, _Height - RectangleHeight), new Point(RectX+widht_unit, _Height - RectangleHeight));
            graphics.DrawString(((RectangleHeight / height_unit)+minY-1).ToString(), new Font(FontFamily.GenericMonospace, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Color.Black), new Point(0, _Height - RectangleHeight));
            graphics.DrawString(((RectX / widht_unit) + minX -1).ToString(), new Font(FontFamily.GenericMonospace, Chart_AxeFontSize, FontStyle.Regular), new SolidBrush(Color.Black), new Point(RectX, _Height),drawFormat);
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            CreateAxes(graphics);
            plot(Data);
        }

    }
}
