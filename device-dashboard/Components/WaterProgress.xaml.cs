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
    /// WaterProgress.xaml 的交互逻辑
    /// </summary>
    public partial class WaterProgress : UserControl
    {
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double),
                typeof(WaterProgress),
                new PropertyMetadata(0.0, new PropertyChangedCallback(OnValueChanged)));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            double newValue = (double)e.NewValue;
            (d as WaterProgress).tth.Y = 160 - newValue * 160 / 100;
        }

        public WaterProgress()
        {
            InitializeComponent();
        }
    }
}
