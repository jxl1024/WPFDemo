using System.Windows;

namespace 路由事件
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

        protected int eventCounter = 0;
        private void SomethingClicked(object sender, RoutedEventArgs e)
        {
            eventCounter++;
            string message = $"#{eventCounter.ToString()}:\r\n" +
                $"Sender:{sender.ToString()}\r\n" +
                $"Source:{e.Source}\r\n" +
                $"Original Source:{e.OriginalSource}";
            lstMessage.Items.Add(message);
            // Handled允许终止事件的冒泡或者终止隧道过程
            // 设置Handled=True，事件就不会继续传递了
            e.Handled = (bool)chkHandle.IsChecked;
        }

        private void cmdClear_click(object sender, RoutedEventArgs e)
        {
            eventCounter = 0;
            lstMessage.Items.Clear();
        }
    }
}
