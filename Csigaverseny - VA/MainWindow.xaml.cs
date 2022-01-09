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

        private double vonal2a;
        internal MainWindow csigaVAblak;
        internal Rectangle csigaUt1;
        internal Rectangle csigaUt2;
        internal Rectangle csigaUt3;
        internal Rectangle rajtVonal;
        internal Rectangle celVonal;
        internal Image csiga01;
        internal Image csiga02;
        internal Image csiga03;
        internal Button startGomb;
        internal Button ujFutam;
        internal Button ujBajnoksag;
        internal Label elertHely1;
        internal Label elertHely2;
        internal Label elertHely3;
        internal Label bajnoksagEredmenyei;
        private bool tartalomBetolt;

        public MainWindow()
        {
            InitializeComponent();
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
    }
}
