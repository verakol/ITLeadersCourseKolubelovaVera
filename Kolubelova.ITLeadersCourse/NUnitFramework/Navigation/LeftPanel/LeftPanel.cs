using NUnitFramework.Navigation.LeftPanel.Groups.AlertsFrameAndWindows;
using NUnitFramework.Navigation.LeftPanel.Groups.Elements;

namespace NUnitFramework.Navigation.LeftPanel
{
    public static class LeftPanel
    {
        public static ElementsGroup Elements => new();

        public static AlertsFrameAndWindowsGroup AlertsFrameAndWindows => new();
    }
}
