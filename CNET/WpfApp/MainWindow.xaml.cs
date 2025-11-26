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
        btnOk.Background = (btnOk.Background == Brushes.Aqua) ? Brushes.BlueViolet : Brushes.Aqua;
    }

    private void btnSeqAll_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();

        txbInfo.Text = "";

        var top10 = FileProcessing.StatsAllFile();

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";
    }

    private async void btnAllAsync_Click(object sender, RoutedEventArgs e)
    {
        Mouse.OverrideCursor = Cursors.Wait;

        Stopwatch time = new Stopwatch();
        time.Start();

        txbInfo.Text = "";

        var top10 = await Task.Run(() => FileProcessing.StatsAllFile());

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";

        Mouse.OverrideCursor = null;
    }
}