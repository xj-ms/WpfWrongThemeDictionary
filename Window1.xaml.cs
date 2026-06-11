using System.Windows;
using System.Windows.Media;

namespace WrongThemeDictionary;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        CustomColorContainer.Items.Add(Brushes.AliceBlue);
    }
}
