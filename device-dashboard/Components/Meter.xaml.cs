using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace device_dashboard.Components
{
    /// <summary>
    /// Meter.xaml 的交互逻辑
    /// </summary>
    public partial class Meter : UserControl
    {
        public string Unit
        {
            get { return (string)GetValue(UnitProperty); }
            set { SetValue(UnitProperty, value); }
        }
        public static readonly DependencyProperty UnitProperty =
            DependencyProperty.Register("Unit", typeof(string), typeof(Meter), new PropertyMetadata(""));


        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        // 依赖属性，上面Value值变化时，执行回调
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(Meter),
                new PropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as Meter).Update();
        }
        private void Update()
        {
            double x1 = radius + radius * 0.6 * Math.Cos(start_angle * Math.PI / 180);
            double y1 = radius + radius * 0.6 * Math.Sin(start_angle * Math.PI / 180);

            double current = this.Value / 100 * 220;
            double x2 = radius + radius * 0.6 * Math.Cos((current + this.start_angle) * Math.PI / 180);
            double y2 = radius + radius * 0.6 * Math.Sin((current + this.start_angle) * Math.PI / 180);

            // Value值变化时回到函数执行到这里，更新Meter中path绘制圆弧的值，即刻度值
            int flag = this.Value > 82 ? 1 : 0;
            string data_str = $"M{x1} {y1} A{radius * 0.6} {radius * 0.6} 0 {flag} 1 {x2} {y2}";
            this.path_value.Data = PathGeometry.Parse(data_str);
        }

        public Meter()
        {
            InitializeComponent();

            this.SizeChanged += Meter_SizeChanged;
        }

        double radius = 0.0;
        double start_angle = 160;
        private void Meter_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.canvas.Children.Clear();

            double w = e.NewSize.Width;
            radius = w / 2;

            if (radius <= 0) return;

            double step = 220.0 / 50;
            int tag = 0;
            for (int i = 0; i <= 50; i++)
            {
                double x1 = radius + radius * Math.Cos((start_angle + i * step) * Math.PI / 180);
                double y1 = radius + radius * Math.Sin((start_angle + i * step) * Math.PI / 180);
                double x2 = radius + (radius - 5) * Math.Cos((start_angle + i * step) * Math.PI / 180);
                double y2 = radius + (radius - 5) * Math.Sin((start_angle + i * step) * Math.PI / 180);

                if (i % 5 == 0)
                {
                    x2 = radius + (radius - 10) * Math.Cos((start_angle + i * step) * Math.PI / 180);
                    y2 = radius + (radius - 10) * Math.Sin((start_angle + i * step) * Math.PI / 180);

                    // 添加刻度标签
                    TextBlock textBlock = new TextBlock();
                    textBlock.Width = 30;
                    textBlock.FontSize = 9;
                    textBlock.TextAlignment = TextAlignment.Center;
                    textBlock.Text = tag.ToString();
                    textBlock.Foreground = new SolidColorBrush(Color.FromArgb(50, 255, 255, 255));
                    tag += 10;

                    double tx1 = radius - 15 + (radius - 20) * Math.Cos((start_angle + i * step) * Math.PI / 180);
                    double ty1 = radius - 5 + (radius - 20) * Math.Sin((start_angle + i * step) * Math.PI / 180);
                    Canvas.SetLeft(textBlock, tx1);
                    Canvas.SetTop(textBlock, ty1);
                    this.canvas.Children.Add(textBlock);
                }

                Line line = new Line();
                line.Stroke = new SolidColorBrush(Color.FromArgb(90, 255, 255, 255));
                line.StrokeThickness = 1;
                line.X1 = x1;
                line.X2 = x2;
                line.Y1 = y1;
                line.Y2 = y2;
                this.canvas.Children.Add(line);
            }

            double px1 = radius + radius * 0.6 * Math.Cos(start_angle * Math.PI / 180);
            double py1 = radius + radius * 0.6 * Math.Sin(start_angle * Math.PI / 180);
            double px2 = radius + radius * 0.6 * Math.Cos((start_angle + 220) * Math.PI / 180);
            double py2 = radius + radius * 0.6 * Math.Sin((start_angle + 220) * Math.PI / 180);

            string data_str = $"M{px1} {py1}A{radius * 0.6} {radius * 0.6} 0 1 1 {px2} {py2}";
            this.path_back.Data = PathGeometry.Parse(data_str);

            this.Update();
        }
    }
}
