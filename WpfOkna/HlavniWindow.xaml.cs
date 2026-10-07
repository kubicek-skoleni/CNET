using System.Windows;

namespace WpfOkna;

/// <summary>
/// Jeden řádek vysvětlení: název vlastnosti, její hodnota v XAML a co dělá.
/// Record je nejkratší zápis třídy, která jen nese data.
/// </summary>
public record Vlastnost(string Nazev, string Hodnota, string Popis);

/// <summary>
/// Normální okno s titulkem a tlačítky. Zobrazuje vysvětlení vlastností obou oken.
/// </summary>
public partial class HlavniWindow : Window
{
    // Stejný text je i v komentářích XAML souborů. Tady je proto, aby ho viděl
    // i ten, kdo si kód neotevře.
    static readonly List<Vlastnost> ZamekSeznam = new()
    {
        new("WindowStyle", "None",
            "Bez titulkového pruhu, bez rámečku, bez tlačítek minimalizovat, maximalizovat a zavřít. Okno nejde chytit myší a přesunout."),
        new("AllowsTransparency", "True",
            "Povolí průhledné pixely. Funguje jen s WindowStyle=None, jinak XAML vyhodí výjimku. Pixely s alfou 0 propouštějí kliknutí do okna pod nimi, proto zámek nemá pozadí Transparent."),
        new("Background", "#80FFFFFF",
            "Barva ve formátu #AARRGGBB: 80 hex = 128 = 50 % alfa, FFFFFF = bílá. Opacity=0.5 na okně by zprůhlednilo i text a tlačítka, alfa v pozadí nechá obsah plně viditelný."),
        new("Topmost", "True",
            "Okno zůstane nad všemi ostatními okny, i když uživatel klikne jinam. Nepřebije jiné Topmost okno."),
        new("WindowState", "Maximized",
            "S WindowStyle=None zabere celou obrazovku včetně hlavního panelu. Pokrývá jen monitor, na kterém se okno otevřelo. Pro všechny monitory se nastaví Left/Top/Width/Height ze SystemParameters.VirtualScreen*."),
        new("ResizeMode", "NoResize",
            "Okno nejde zvětšit ani zmenšit, a zmizí i minimalizace z nabídky Alt+mezerník. Další hodnoty: CanResize (výchozí), CanMinimize, CanResizeWithGrip."),
        new("ShowInTaskbar", "False",
            "Okno nemá tlačítko na hlavním panelu, uživatel ho nemůže minimalizovat kliknutím."),
        new("FocusManager.FocusedElement", "{Binding ElementName=KodTextBox}",
            "Kurzor se po otevření postaví rovnou do políčka. Pojistka je ve Window_Loaded: Activate() a KodTextBox.Focus()."),
        new("Closing", "Window_Closing",
            "Alt+F4 zavře i okno bez tlačítek. Obsluha nastaví e.Cancel = true, dokud není zadaný správný kód. Není to bezpečnostní prvek: Ctrl+Alt+Del a klávesa Windows fungují dál."),
        new("Button.IsDefault", "True",
            "Enter kdekoli v okně stiskne toto tlačítko. IsCancel=True by tlačítko spojilo s klávesou Esc."),
        new("TextBox", "",
            "Obyčejné textové pole. Pro skutečné heslo se použije PasswordBox, ten text maskuje tečkami a má vlastnost Password místo Text."),
        new("Border.Effect", "DropShadowEffect",
            "Stín kolem formuláře. Vykreslí se jen díky AllowsTransparency, jinak nemá kam."),
    };

    static readonly List<Vlastnost> HlavniSeznam = new()
    {
        new("Title", "Hlavní okno - odemčeno",
            "Text v titulkovém pruhu, na hlavním panelu a v Alt+Tab."),
        new("WindowStyle", "(nenastaveno = SingleBorderWindow)",
            "Titulkový pruh s ikonou a třemi tlačítky. Další hodnoty: ThreeDBorderWindow, ToolWindow (úzký pruh, jen zavírací tlačítko, není na hlavním panelu), None."),
        new("Width / Height", "760 / 620",
            "Počáteční velikost. Místo nich lze použít SizeToContent=WidthAndHeight, okno se pak přizpůsobí obsahu."),
        new("MinWidth / MinHeight", "480 / 300",
            "Meze pro změnu velikosti myší. Uživatel okno pod tyto hodnoty nezmenší. Existuje i MaxWidth / MaxHeight."),
        new("WindowStartupLocation", "CenterScreen",
            "Okno se otevře uprostřed obrazovky. Výchozí Manual nechá rozhodnout Windows nebo použije Left/Top. CenterOwner vycentruje okno nad vlastníkem, hodí se pro dialogy přes ShowDialog()."),
        new("ResizeMode", "CanResizeWithGrip",
            "Jako CanResize, navíc s úchytem v pravém dolním rohu."),
        new("ShowInTaskbar", "True",
            "Výchozí hodnota, zapsaná jen pro kontrast se zámkem."),
        new("SizeChanged / StateChanged", "obsluhy událostí",
            "Události okna. Tady vypisují ActualWidth, ActualHeight, WindowState (Normal, Minimized, Maximized) a Left/Top do řádku dole."),
        new("ItemsControl + DataTemplate", "tento seznam",
            "ItemsControl vykreslí každý prvek seznamu podle šablony. Šablona je v Window.Resources, {Binding Nazev} čte vlastnost záznamu."),
    };

    static readonly List<Vlastnost> AppSeznam = new()
    {
        new("StartupUri", "ZamekWindow.xaml",
            "První okno, které aplikace po startu otevře. Tady zámek, ne hlavní okno."),
        new("ShutdownMode", "OnLastWindowClose",
            "Výchozí hodnota: aplikace běží, dokud je otevřené aspoň jedno okno. Proto zámek nejdřív otevře hlavní okno a teprve pak se zavře. Další možnosti: OnMainWindowClose (konec se zavřením prvního okna), OnExplicitShutdown (konec jen po Application.Current.Shutdown())."),
    };

    public HlavniWindow()
    {
        InitializeComponent();

        // ItemsSource je seznam, ze kterého ItemsControl bere prvky.
        ZamekVlastnosti.ItemsSource = ZamekSeznam;
        HlavniVlastnosti.ItemsSource = HlavniSeznam;
        AppVlastnosti.ItemsSource = AppSeznam;

        VypisStav();
    }

    void Zamknout_Click(object sender, RoutedEventArgs e)
    {
        // Stejné pořadí jako v zámku: nejdřív otevřít nové okno, pak zavřít toto,
        // jinak by zavření posledního okna ukončilo aplikaci (ShutdownMode v App.xaml).
        new ZamekWindow().Show();
        Close();
    }

    void Window_SizeChanged(object sender, SizeChangedEventArgs e) => VypisStav();

    void Window_StateChanged(object sender, EventArgs e) => VypisStav();

    void VypisStav()
    {
        // StavTextBlock existuje až po InitializeComponent(), a SizeChanged může
        // přijít dřív než konstruktor doběhne. Proto kontrola na null.
        if (StavTextBlock == null)
            return;

        // ActualWidth/ActualHeight je skutečná velikost po rozvržení.
        // Width/Height je požadovaná hodnota a může být NaN (Auto), např. se SizeToContent.
        // WindowState: Normal, Minimized, Maximized.
        StavTextBlock.Text =
            $"Velikost: {ActualWidth:0} × {ActualHeight:0}   Stav: {WindowState}   Pozice: {Left:0}, {Top:0}";
    }
}
