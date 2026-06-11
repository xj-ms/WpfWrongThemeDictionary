using System.Windows;
using System.Windows.Controls;

namespace WrongThemeDictionary;

internal class CustomContainer : ItemsControl
{
    protected override DependencyObject GetContainerForItemOverride()
    {
        return new CustomControl();
    }
}
