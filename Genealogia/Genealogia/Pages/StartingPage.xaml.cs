using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

using Genealogia.DataPages;
namespace Genealogia.Pages;

public sealed partial class StartingPage : Page
{
    private readonly StartingPageData m_pageData = new();

    public StartingPage()
    {
        this.InitializeComponent();
    }
}
