using System.Diagnostics;
using System.Windows;

namespace wpfguiDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    [wpfgui.Gui]
    public float value = 0;

    [wpfgui.Gui(0, 100)]
    public float x = 0;

    [wpfgui.Gui]
    public string name = "Hello";

    [wpfgui.Gui]
    public Animals animal;

    public enum Animals
    {
        Cat,
        Dog,
        Bird
    }

    [wpfgui.Gui]
    public void Log()
    {
        Trace.WriteLine("Hello");
    }

    public MainWindow()
    {
        InitializeComponent();

        wpfgui.GUIWindow.Register(this);
    }
}
