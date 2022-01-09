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
using System.Windows.Threading;

namespace Csigaverseny___VA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<MainWindow.Csiga> versenyzok;
        private DispatcherTimer timer = new DispatcherTimer();
        private int helyezes = 1;
        private SolidColorBrush[] ermek = new SolidColorBrush[3]
        {
          Brushes.Gold,
          Brushes.Silver,
          Brushes.SandyBrown
        };

        private bool tartalomBetolt;
        private double celvonalErteke;

        public MainWindow()
        {
            InitializeComponent();
            ujBajnoksag.Click += new RoutedEventHandler(ujFutamGomb);
            csigakBeallitasa();
            timer.Interval = TimeSpan.FromSeconds(0.051);
            timer.Tick += new EventHandler(timer_Tick);
            Random rnd = new Random();
            ujFutam.IsEnabled = false;
            celvonalErteke = vonal2.Margin.Left;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void csigakBeallitasa()
        {
            throw new NotImplementedException();
        }

        private void startG(object sender, RoutedEventArgs e)
        {

        }

        private void ujFutamGomb(object sender, RoutedEventArgs e)
        {

        }

        private void ujBajnoksagGomb(object sender, RoutedEventArgs e)
        {

        }

        private class Csiga
        {
        }
    }
}
