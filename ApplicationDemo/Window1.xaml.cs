using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ApplicationDemo
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"Main Window is:{Application.Current.MainWindow.Title}");
            //foreach (Window item in Application.Current.Windows)
            //{
            //    MessageBox.Show($"{item.Title} is opened");
            //}

            Document document = new Document();
            document.Owner = this;
            document.Show();
            // 添加到集合中
            ((App)Application.Current).Documents.Add(document);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Document item in ((App)Application.Current).Documents)
            {
                item.Content = $"Refresh at:{DateTime.Now}";
            }
        }
    }
}
