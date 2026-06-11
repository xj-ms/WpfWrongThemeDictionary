using System.Diagnostics;
using System.Windows;

namespace WrongThemeDictionary;

internal static class Program
{
    [STAThread]
    private static int Main()
    {
        new FrameworkElement(); // Initialize FrameworkElement without Application.Current
        _ = new Application(); // Initialize Application.Current
        ResourceDictionary dict = new() { Source = new Uri("/Styles.xaml", UriKind.Relative) }; // Trigger ToolBar class initializer while parsing system resources

        // Application.Current.Resources.IsThemeDictionary == true
        Debug.Assert(typeof(ResourceDictionary).GetProperty("IsThemeDictionary", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)!.GetValue(Application.Current.Resources) is true);
        Application.Current.Resources.MergedDictionaries.Add(dict); // Whatever merged becomes theme resources too

        Application.Current.Run(new Window1());

        return 0;
    }
}
