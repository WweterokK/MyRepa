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
using System.Drawing;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Point p1, p2;
        bool isMove;
        private bool button1WasClicked = false;
        private bool button2WasClicked = false;
        private bool bln = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BLN_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(BLN_Click);
            btn.Click += new RoutedEventHandler(BLN_Click_1);
            bln = true;
        }
        private void BLN_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(BLN_Click_1);
            btn.Click += new RoutedEventHandler(BLN_Click);
            bln = false;
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
                        
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(Button_Click_1);
            btn.Click += new RoutedEventHandler(Button_Click_1_1);
            button1WasClicked = true;
        }
        private void Button_Click_1_1(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(Button_Click_1_1);
            btn.Click += new RoutedEventHandler(Button_Click_1);
            button1WasClicked = false;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(Button_Click_2);
            btn.Click += new RoutedEventHandler(Button_Click_2_2);
            button2WasClicked = true;
        }
        private void Button_Click_2_2(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Click -= new RoutedEventHandler(Button_Click_2_2);
            btn.Click += new RoutedEventHandler(Button_Click_2);
            button2WasClicked = false;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void canvas_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            p1 = Mouse.GetPosition(canvas);
            if (button2WasClicked == true)
            {
                if ((e.LeftButton.ToString() == "Pressed") && !(e.OriginalSource is Rectangle))
                {
                    var myRect = new Rectangle();
                    myRect.Fill = Brushes.OrangeRed;
                    myRect.Width = 10; 
                    myRect.Height = 10; 
                    int PositionX = (int)(Math.Floor(e.GetPosition(canvas).X / 10) * 10);
                    int PositionY = (int)(Math.Floor(e.GetPosition(canvas).Y / 10) * 10);
                    Canvas.SetLeft(myRect, PositionX);
                    Canvas.SetTop(myRect, PositionY);
                    canvas.Children.Add(myRect);
                }
            }
            if(button1WasClicked == true)
            {
                if ((e.LeftButton.ToString() == "Pressed") && !(e.OriginalSource is Ellipse))
                {
                    Point m = new Point();
                    int mX = (int)m.X;
                    int mY = (int)m.Y;
                    var el = new Ellipse();
                if (RBred.IsChecked == true)
                {
                    el.Fill = Brushes.Red;
                }
                if (RBgreen.IsChecked == true)
                {
                    el.Fill = Brushes.Green;
                }
                if (RBblue.IsChecked == true)
                {
                    el.Fill = Brushes.Blue;
                }
                if (RBbraun.IsChecked == true)
                {
                    el.Fill = Brushes.Brown;
                }
                if (RBlgreen.IsChecked == true)
                {
                    el.Fill = Brushes.LightSeaGreen;
                }
                if (RByellow.IsChecked == true)
                {
                    el.Fill = Brushes.Yellow;
                }
                if (RBpurple.IsChecked == true)
                {
                    el.Fill = Brushes.Purple;
                }
                if (RBpink.IsChecked == true)
                {
                    el.Fill = Brushes.Pink;
                }
                if (RBwhite.IsChecked == true)
                {
                    el.Fill = Brushes.White;
                }
                if (RBgray.IsChecked == true)
                {
                    el.Fill = Brushes.Gray;
                }
                if (RBorange.IsChecked == true)
                {
                    el.Fill = Brushes.Orange;
                }
                if (RBblack.IsChecked == true)
                {
                    el.Fill = Brushes.Black;
                }
                    el.Stroke = Brushes.Black;
                    el.Width = 10;
                    el.Height = 10;
                    int PositionX = (int)(Math.Floor(e.GetPosition(canvas).X / 10) * 10);
                    int PositionY = (int)(Math.Floor(e.GetPosition(canvas).Y / 10) * 10);
                    Canvas.SetLeft(el, PositionX);
                    Canvas.SetTop(el, PositionY);
                    canvas.Children.Add(el);
                }
            }
        }

        private void canvas_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            p2 = Mouse.GetPosition(canvas);
            DrawLine(p1, p2, false);
            isMove = true;
        }

        private void canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point p = Mouse.GetPosition(canvas);
                DrawLine(p1, p, true);
            }
            
                if (button2WasClicked == true)
                {
                    if ((e.LeftButton.ToString() == "Pressed") && !(e.OriginalSource is Rectangle))
                   {                  
                        var myRect = new Rectangle();
                        myRect.Fill = Brushes.OrangeRed;
                        myRect.Width = 10; 
                        myRect.Height = 10; 
                        int PositionX = (int)(Math.Floor(e.GetPosition(canvas).X / 10) * 10); 
                        int PositionY = (int)(Math.Floor(e.GetPosition(canvas).Y / 10) * 10);
                        Canvas.SetLeft(myRect, PositionX);
                        Canvas.SetTop(myRect, PositionY);
                        canvas.Children.Add(myRect);                                
                   }                    
                }
            if (button1WasClicked == true)
            {
                if ((e.LeftButton.ToString() == "Pressed") && !(e.OriginalSource is Ellipse))
                {
                    Point m = new Point();
                    int mX = (int)m.X;
                    int mY = (int)m.Y;
                    var el = new Ellipse();
                    if (RBred.IsChecked == true)
                    {
                        el.Fill = Brushes.Red;
                    }
                    if (RBgreen.IsChecked == true)
                    {
                        el.Fill = Brushes.Green;
                    }
                    if (RBblue.IsChecked == true)
                    {
                        el.Fill = Brushes.Blue;
                    }
                    if (RBbraun.IsChecked == true)
                    {
                        el.Fill = Brushes.Brown;
                    }
                    if (RBlgreen.IsChecked == true)
                    {
                        el.Fill = Brushes.LightSeaGreen;
                    }
                    if (RByellow.IsChecked == true)
                    {
                        el.Fill = Brushes.Yellow;
                    }
                    if (RBpurple.IsChecked == true)
                    {
                        el.Fill = Brushes.Purple;
                    }
                    if (RBpink.IsChecked == true)
                    {
                        el.Fill = Brushes.Pink;
                    }
                    if (RBwhite.IsChecked == true)
                    {
                        el.Fill = Brushes.White;
                    }
                    if (RBgray.IsChecked == true)
                    {
                        el.Fill = Brushes.Gray;
                    }
                    if (RBorange.IsChecked == true)
                    {
                        el.Fill = Brushes.Orange;
                    }
                    if (RBblack.IsChecked == true)
                    {
                        el.Fill = Brushes.Black;
                    }
                    el.Stroke = Brushes.Black;
                    el.Width = 10;
                    el.Height = 10;
                    int PositionX = (int)(Math.Floor(e.GetPosition(canvas).X / 10) * 10);
                    int PositionY = (int)(Math.Floor(e.GetPosition(canvas).Y / 10) * 10);
                    Canvas.SetLeft(el, PositionX);
                    Canvas.SetTop(el, PositionY);
                    canvas.Children.Add(el);
                }
            }
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TX1_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(TX1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }

        private void TX2_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(TX2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели символ! Пожалуйста,введите цифрy");
            }
        }

        

        private void DrawLine(Point start, Point stop, bool move)
        {
           
                Line line = new Line();

            if (RBred.IsChecked == true) 
            {
                line.Stroke = Brushes.Red;
            }
            if (RBgreen.IsChecked == true)
            {
                line.Stroke = Brushes.Green;
            }
            if (RBblue.IsChecked == true)
            {
                line.Stroke = Brushes.Blue;
            }
            if (RBbraun.IsChecked == true)
            {
                line.Stroke = Brushes.Brown;
            }
            if (RBlgreen.IsChecked == true)
            {
                line.Stroke = Brushes.LightSeaGreen;
            }
            if (RByellow.IsChecked == true)
            {
                line.Stroke = Brushes.Yellow;
            }
            if (RBpurple.IsChecked == true)
            {
                line.Stroke = Brushes.Purple;
            }
            if (RBpink.IsChecked == true)
            {
                line.Stroke = Brushes.Pink;
            }
            if (RBwhite.IsChecked == true)
            {
                line.Stroke = Brushes.White;
            }
            if (RBgray.IsChecked == true)
            {
                line.Stroke = Brushes.Gray;
            }
            if (RBorange.IsChecked == true)
            {
                line.Stroke = Brushes.Orange;
            }
            if (RBblack.IsChecked == true)
            {
                line.Stroke = Brushes.Black;
            }
            if (bln == true)
            {
                line.X1 = start.X;
                line.X2 = stop.X;
                line.Y1 = start.Y;
                line.Y2 = stop.Y;
                if (!move)
                    canvas.Children.Add(line);
                else
                    if (canvas.Children.Count > 2 && !isMove)
                {
                    canvas.Children.RemoveAt(canvas.Children.Count - 1);
                    canvas.Children.Add(line);
                }
                else
                {
                    canvas.Children.Add(line);
                    isMove = false;
                }
            }
        }
    }
}
