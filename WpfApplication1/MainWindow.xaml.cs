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
using System.Windows.Media.Animation;
using Microsoft.Runtime;
using Microsoft.Win32;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
                        
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ellipse el = new Ellipse();
            el.Width = Convert.ToInt32(TX1.Text);
            el.Height = Convert.ToInt32(TX2.Text);
            el.VerticalAlignment = VerticalAlignment.Center;
            el.StrokeThickness = 3;
            var conv = new System.Windows.Media.BrushConverter();
            var bru = (Brush)conv.ConvertFromString(TX3.Text);
            var br = (Brush)conv.ConvertFromString(TX4.Text);
            el.Fill = bru;
            el.Stroke = br;
            canvasPlate.Children.Add(el);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Rectangle rec = new Rectangle();
            rec.Width = Convert.ToInt32(TX1.Text);;
            rec.Height = Convert.ToInt32(TX2.Text);;
            rec.VerticalAlignment = VerticalAlignment.Center;
            rec.StrokeThickness = 3;         
            rec.Fill = Brushes.White;;
            rec.Stroke = Brushes.Gray;
            canvasPlate.Children.Add(rec);
            InitializeComponent();           
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            canvasPlate.Children.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
