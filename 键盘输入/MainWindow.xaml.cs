using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace 键盘输入
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            lstMessage.Items.Clear();
        }

        private void KeyEvent(object sender, KeyEventArgs e)
        {
            string msg = $"Event:{e.RoutedEvent},Key:{e.Key}";
            lstMessage.Items.Add(msg);
        }

        private void txtBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string msg = $"Event:{e.RoutedEvent},Text:{e.Text}";
            lstMessage.Items.Add(msg);
        }

        private void txtBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string msg = $"Event:{e.RoutedEvent}";
            lstMessage.Items.Add(msg);
        }
    }
}
