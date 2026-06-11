namespace WrongThemeDictionary;

internal class CustomControl : System.Windows.Controls.Border
{
    static CustomControl()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new System.Windows.FrameworkPropertyMetadata(typeof(CustomControl)));
    }
}
