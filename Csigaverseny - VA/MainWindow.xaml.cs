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
            Bajnoksag = new Bajnoksag();
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
            public int pontSzam = 0;
            public int elsoHelyekSzama = 0;
            public int masodikHelyezesekSzama = 0;
            public int harmadikHelyezesekSzama = 0;

            public Csiga(string csigaNev)
            {
                csNev = csigaNev;
            }

            public string Nev
            {
                get => csNev;
                private set => csNev = value;
            }
            public void Move(double celvonalErtek, int randomszam)
            {

            }
        }
    }
    public class Bajnoksag
    {
        public List<MainWindow.Csiga> pontozasiSorrend = new List<MainWindow.Csiga>();

        public void uj()
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < pontozasiSorrend.Count() - 1; i++)
                {
                    if (pontozasiSorrend[i].pontSzam < pontozasiSorrend[i + 1].pontSzam)
                    {
                        var higherValue = pontozasiSorrend[i];
                        pontozasiSorrend[i] = pontozasiSorrend[i + 1];
                        pontozasiSorrend[i + 1] = higherValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }
    }
}
