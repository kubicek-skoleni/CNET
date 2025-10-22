using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        byte counter = byte.MaxValue;

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            //txtInfo.Text = int.MaxValue.ToString("N");

            counter++;

            txtInfo.Text = counter.ToString();


            //txtInfo.Text = "Hello World!";

            //if(rctBox1.Fill == Brushes.Cornsilk)
            //    rctBox1.Fill = Brushes.LightBlue;
            //else
            //    rctBox1.Fill = Brushes.Cornsilk;

            int nahodny_cislo = Random.Shared.Next(0, 11);

            rctBox1.Fill = nahodny_cislo switch
            {
                0 => Brushes.Cornsilk,
                1 => Brushes.LightBlue,
                2 => Brushes.LightGreen,
                3 => Brushes.LightPink,
                4 => Brushes.LightGray,
                5 => Brushes.LightYellow,
                6 => Brushes.Orange,
                7 => Brushes.Violet,
                8 => Brushes.LightCoral,
                9 => Brushes.Aquamarine,
                10 => Brushes.Gold,
                _ => Brushes.White
            };
        }
    }
}