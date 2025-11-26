using System.Diagnostics;
using System.IO;
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

namespace WpfApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnOk_Click(object sender, RoutedEventArgs e)
    {
        txbInfo.Text = "Hello WPF!";
    }

    private void btnSeqAll_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();

        string dir = @"C:\PROJECTS\skoleni\2025_komfi\BigFiles";
        var files = Directory.GetFiles(dir);

        Dictionary<string, int> stats = new();
        foreach (var file in files)
        {


        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";
    }
}