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

        IProgress<(string file, double percent)> progress 
            = new Progress<(string file, double percent)>(tuple =>
        {
            txbInfo.Text += $"zpracovávám soubor {tuple.file}: {tuple.Item2}% hotovo {Environment.NewLine}";
        });

        var top10 = await Task.Run(() => FileProcessing.StatsAllFile(progress));

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";

        Mouse.OverrideCursor = null;
    }

    private void btnAllParallel_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();
        txbInfo.Text = "";

        var files = Directory.GetFiles(FileProcessing.dir);
        
        Parallel.ForEach(files,file =>
        {
            var words = File.ReadAllLines(file);
            foreach (var word in words)
            {
                FileProcessing.statsConcurrent
                .AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
            }
        });

        var top10 = FileProcessing.statsConcurrent.OrderByDescending(kv => kv.Value).Take(10);

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";

    }

    private async void btnAllParallelAsync_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();
        txbInfo.Text = "";

        var files = Directory.GetFiles(FileProcessing.dir);

        await Parallel.ForEachAsync(files, async (file, cancellationToken) =>
        {
            var words = File.ReadAllLines(file);
            foreach (var word in words)
            {
                FileProcessing.statsConcurrent
                .AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
            }
        });

        var top10 = FileProcessing.statsConcurrent.OrderByDescending(kv => kv.Value).Take(10);

        foreach (var kv in top10)
        {
            txbInfo.Text += $"{kv.Key}: {kv.Value}{Environment.NewLine}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";

    }

    private void btnTasks1_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();
        txbInfo.Text = "";

        string[] urls = [
            "https://seznam.cz",
            "https://komfi.cz",
            "https://novinky.cz"
        ];

        var task3 = Task.Run(() => WebLoad.LoadUrl(urls[2]));
        var task1 = Task.Run(() => WebLoad.LoadUrl(urls[0]));
        var task2 = Task.Run(() => WebLoad.LoadUrl(urls[1]));
        
        Task[] tasks = [ task1, task3, task2];

        var first = Task.WaitAny(tasks);
               
        txbInfo.Text += $"Doběhl první task: {urls[first]}";

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";
    }

    private async void btnTasks2_Click(object sender, RoutedEventArgs e)
    {
        Stopwatch time = new Stopwatch();
        time.Start();
        txbInfo.Text = "";

        string[] urls = [
            "https://seznam.cz",
            "https://komfi.cz",
            "https://novinky.cz"
        ];

        var task3 = Task.Run(() => WebLoad.LoadUrl(urls[2]));
        var task1 = Task.Run(() => WebLoad.LoadUrl(urls[0]));
        var task2 = Task.Run(() => WebLoad.LoadUrl(urls[1]));

        var first = await Task.WhenAny(task1, task2, task3);

        var first_result = first.Result;

        txbInfo.Text += $"Doběhl první task {Environment.NewLine}";
        if (first_result.IsSuccess)
        {
            txbInfo.Text += $"length: {first_result.Content.Length}";
        }
        else
        {
            txbInfo.Text += $"error: {first_result.ErrorMessage}";
        }

        time.Stop();
        txbInfo.Text += $"{Environment.NewLine} Time: {time.ElapsedMilliseconds} ms";
    }
}