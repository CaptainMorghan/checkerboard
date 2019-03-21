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

namespace Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Rectangle r = new Rectangle();
                    r.Height = 100;
                    r.Width = 100;
                    if (x % 2 == 0 && y % 2 == 0 || x % 2 == 1 && y % 2 ==1)
                    {
                        r.Fill = Brushes.Red;
                    }
                    else
                    {
                        r.Fill = Brushes.Blue;
                    }
                    canvus.Children.Add(r);
                    Canvas.SetTop(r, x * 100);
                    Canvas.SetLeft(r, y * 100);
                }
            }
 
        }
    }
}
