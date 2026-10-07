using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfOkna;

/// <summary>
/// Celoobrazovkový zámek. Vlastnosti okna (bez rámečku, průhledné, vždy navrchu)
/// jsou nastavené a popsané v ZamekWindow.xaml. Tady je jen logika kódu.
/// </summary>
public partial class ZamekWindow : Window
{
    const string SpravnyKod = "1234";

    // Zámek odemkne jen správný kód. Dokud je false, obsluha Closing okno nepustí.
    bool odemceno = false;

    public ZamekWindow()
    {
        InitializeComponent();
    }

    void Window_Loaded(object sender, RoutedEventArgs e)
    {
        // Activate() přitáhne okno do popředí a dá mu klávesnici, i když ho otevřelo
        // jiné okno, které bylo zrovna aktivní. Topmost samo o sobě fokus nedává.
        Activate();
        // FocusManager.FocusedElement v XAML většinou stačí. Focus() tady je pojistka
        // pro případ, že okno dostane fokus až po Loaded (např. při startu z Visual Studia).
        KodTextBox.Focus();
    }

    void Odemknout_Click(object sender, RoutedEventArgs e)
    {
        if (KodTextBox.Text == SpravnyKod)
        {
            odemceno = true;

            // Nejdřív otevřít hlavní okno, teprve pak zavřít zámek. V opačném pořadí
            // by s ShutdownMode=OnLastWindowClose zavření zámku ukončilo celou aplikaci.
            new HlavniWindow().Show();
            Close();
        }
        else
        {
            ChybaTextBlock.Text = "Špatný kód, zkus to znovu.";
            ChybaTextBlock.Visibility = Visibility.Visible;
            // Vybrat celý text: další psaní ho přepíše, uživatel nemusí mazat.
            KodTextBox.SelectAll();
            KodTextBox.Focus();
        }
    }

    void KodTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        // Jakmile uživatel začne psát, chybová hláška zmizí.
        ChybaTextBlock.Visibility = Visibility.Collapsed;
    }

    void Window_Closing(object sender, CancelEventArgs e)
    {
        // Closing přijde i při Alt+F4 nebo při Close() z kódu. e.Cancel = true
        // zavření zastaví. Bez této obsluhy by Alt+F4 zámek obešlo.
        // Toto je ukázka vlastností okna, ne bezpečnostní prvek: Ctrl+Alt+Del,
        // klávesa Windows a Správce úloh fungují dál.
        if (!odemceno)
            e.Cancel = true;
    }
}
