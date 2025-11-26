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

        txbInfo.Text = "";
        string dir = @"C:\PROJECTS\skoleni\2025_komfi\BigFiles";
        var files = Directory.GetFiles(dir);

        Dictionary<string, int> stats = new();
        foreach (var file in files)
        {
            var words = File.ReadLines(file);

            foreach (var word in words)
            {
                if (stats.ContainsKey(word))
                    stats[word]++;
                else
                    stats[word] = 1;
            }
        }

        var top10 = stats.OrderByDescending(kv => kv.Value).Take(10);

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";
    }

    private void btnAllAsync_Click(object sender, RoutedEventArgs e)
    {
        Mouse.OverrideCursor = Cursors.Wait;

        Stopwatch time = new Stopwatch();
        time.Start();

        txbInfo.Text = "";
        string dir = @"C:\PROJECTS\skoleni\2025_komfi\BigFiles";
        var files = Directory.GetFiles(dir);

        Dictionary<string, int> stats = new();
        foreach (var file in files)
        {
            var words = File.ReadLines(file);

            foreach (var word in words)
            {
                if (stats.ContainsKey(word))
                    stats[word]++;
                else
                    stats[word] = 1;
            }
        }

        var top10 = stats.OrderByDescending(kv => kv.Value).Take(10);

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";

        Mouse.OverrideCursor = null;
    }
}