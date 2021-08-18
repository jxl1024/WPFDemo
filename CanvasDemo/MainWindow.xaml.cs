using System.Windows;
using System.Windows.Controls;

namespace CanvasDemo
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

        /// <summary>
        /// 点击按钮，修改ZIndex属性值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            // 设置按钮的ZIndex属性
            Canvas.SetZIndex(this.btn, 2);
        }
    }
}
