using NUnitFramework.Pages.Elements;

namespace NUnitFramework.Navigation.LeftPanel.Groups.Elements
{
    public class ElementsGroup : BaseGroup
    {
        public DynamicPropertiesPage DynamicProperties() => NavigateTo<DynamicPropertiesPage>("dynamic-properties");
    }
}
