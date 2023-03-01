using WinUIEx;

using Genealogia.Pages;

namespace Genealogia.Windows;

public sealed partial class StartingWindow : WindowEx
{
    public StartingWindow()
    {
        this.InitializeComponent();

        // Modification de la barre de titre
        AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/StoreLogo.ico"));  // TODO : Vérifier si cette ligne est utile, une fois le logo défini ??
        ExtendsContentIntoTitleBar = true;
        SetTitleBar(TitleBar);

        
        RootFrame.Navigate(typeof(MainWorkingPage));
    }

}
