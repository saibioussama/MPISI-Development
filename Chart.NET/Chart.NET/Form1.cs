using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart.NET
{
    public partial class Form1  : Form
    {
        Graphics graphics;
        int _Height = 0;
        int _Widht = 0;
        int StartX = 0;
        int StartY = 0;

        List<int> XData = new List<int>();

        List<int> YData = new List<int>();

        private void GenerateFakeData(int x)
        {
            for (int i = 0; i < x; i++)
            {
                XData.Add(new Random().Next(1,x));
                YData.Add(i);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<int> XData, List<int> YData)
        {
            InitializeComponent();
            XData = XData;
            YData = YData;
        }

        private void CreateAxe(Graphics graphics,string x,string y,Color Foregorund,Color BorderColor,int FontSize = 11)
        {
            _Height = Canvas.Height - Canvas.Margin.Bottom;
            _Widht = Canvas.Width - Canvas.Margin.Left;
            StartX = Canvas.Margin.Left;
            StartY = Canvas.Margin.Bottom;
            graphics.DrawString(y, new Font(FontFamily.GenericSerif, FontSize, FontStyle.Regular), new SolidBrush(Foregorund), new Point(StartX, StartY));
            graphics.DrawString(x, new Font(FontFamily.GenericSerif, FontSize, FontStyle.Regular), new SolidBrush(Foregorund), new Point(_Widht, _Height));
            graphics.DrawString("0", new Font(FontFamily.GenericSerif, FontSize, FontStyle.Regular), new SolidBrush(Foregorund), new Point(StartX, _Height));
            graphics.DrawLine(new Pen(BorderColor), new Point(StartX, StartY), new Point(StartX, _Height));
            graphics.DrawLine(new Pen(BorderColor), new Point(StartX, _Height), new Point(_Widht, _Height));
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            GenerateFakeData(40);
            graphics = e.Graphics;
            CreateAxe(graphics,"X","Y",Color.DodgerBlue,Color.DodgerBlue);
            plot(XData, YData,Color.DeepSkyBlue,Color.Blue);
        }

        private List<Tuple<int,int>> MapData(List<int> XData, List<int> YData)
        {
            List<Tuple<int, int>> Data = new List<Tuple<int, int>>();
            for (int i = 0; i < XData.Count; i++)
            {
                Data.Add(new Tuple<int, int>(XData[i], YData[i]));
            }
            return Data; 
        }

        private void plot(List<int> XData, List<int> YData, Color Background, Color BorderColor)
        {

            if(XData.Count != YData.Count)
            {
                MessageBox.Show("data invalid ");
                return;
            }

            List<Tuple<int, int>> Data = MapData(XData,YData);

            var widht_unit = (Width - (StartX * 2)) / Data.Count - 1;
            var height_unit = (_Height - StartY) / Data.Count - 1;
            foreach (var point in Data)
            {
                var height = point.Item2 * height_unit;
                var widht = widht_unit;
               DrawRectangle(height, widht, StartX + (point.Item1 - 1) * widht, _Height - height,Background,BorderColor);
                
            }
        }

        private void DrawRectangle(int height,int width,int x,int y,Color Background,Color BorderColor)
        {
            var r = new Rectangle()
            {
                Height = height,
                Width = width, 
                X = x, 
                Y = y
            };
            Pen pen = new Pen(new SolidBrush(BorderColor));
            graphics.FillRectangle(new SolidBrush(Background), r);
            graphics.DrawRectangle(pen, r);
        }
    }
}
