using NUnitFramework.Pages;

namespace NUnitFramework.Navigation.LeftPanel.Interfaces
{
    public interface ILeftPanelGroup
    {
        T NavigateTo<T>(string path) where T : BasePage, new();
    }
}
