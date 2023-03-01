using Microsoft.UI.Xaml;
using WinUIEx;

using Genealogia.Windows;

namespace Genealogia;


public partial class App : Application
{
    private static WindowEx? m_window;

    public App()
    {
        this.InitializeComponent();
    }

    protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
    {
        m_window = new StartingWindow();
        m_window.Activate();
    }
}
