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
        Random rnd = new Random();
        private object vonal2a;

        public MainWindow()
        {
            InitializeComponent();
            ujBajnoksag.Click += new RoutedEventHandler(ujFutamGomb);
            csigakBeallitasa();
            timer.Interval = TimeSpan.FromSeconds(0.051);
            timer.Tick += new EventHandler(timer_Tick);
            ujFutam.IsEnabled = false;
            celvonalErteke = vonal2.Margin.Left;
        }

        private void csigakBeallitasa()
        {
            versenyzok = new List<MainWindow.Csiga>();
            versenyzok.Add(new MainWindow.Csiga("csiga1"));
            versenyzok.Add(new MainWindow.Csiga("csiga2"));
            versenyzok.Add(new MainWindow.Csiga("csiga3"));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
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



        public class Csiga
        {
            private string csNev;
            private int pont;
            private int[] helyezes;
            private int[] pontok = new int[4] { 0, 3, 2, 1 };

            public Csiga(string csigaNev)
            {
                csNev = csigaNev;
                helyezes = new int[4];
            }

            public int Pont => helyezes[1] * pontok[1] + helyezes[2] * pontok[2] + helyezes[3] * pontok[3];

            public string Nev
            {
                get => csNev;
                private set => csNev = value;
            }

            public int[] Helyezes
            {
                get => helyezes;
                set => helyezes = value;

            }
        }
    }
}
