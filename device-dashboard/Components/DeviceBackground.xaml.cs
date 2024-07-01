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
    /// DeviceBackground.xaml 的交互逻辑
    /// </summary>
    public partial class DeviceBackground : UserControl
    {

        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(
                "Source",
                typeof(ImageSource),
                typeof(DeviceBackground),
                new PropertyMetadata(null));


        public DeviceBackground()
        {
            InitializeComponent();

            this.SizeChanged += DeviceBackground_SizeChanged;
        }

        private void DeviceBackground_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.canvas.Children.Clear();

            double radius = 125.0;
            for (int i = 0; i < 360; i += 2)
            {
                // Sin Cos
                double x1 = radius + radius * Math.Cos(i * Math.PI / 180);
                double y1 = radius + radius * Math.Sin(i * Math.PI / 180);

                double x2 = radius + (radius - 10) * Math.Cos(i * Math.PI / 180);
                double y2 = radius + (radius - 10) * Math.Sin(i * Math.PI / 180);

                if (i % 4 == 0)
                {
                    x1 = radius + radius * Math.Cos(i * Math.PI / 180);
                    y1 = radius + radius * Math.Sin(i * Math.PI / 180);

                    x2 = radius + (radius - 5) * Math.Cos(i * Math.PI / 180);
                    y2 = radius + (radius - 5) * Math.Sin(i * Math.PI / 180);
                }

                Line line = new Line
                {
                    X1 = x1,
                    Y1 = y1,
                    X2 = x2,
                    Y2 = y2,
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 255, 255, 255)),
                    StrokeThickness = 1
                };

                this.canvas.Children.Add(line);
            }
        }
    }
}