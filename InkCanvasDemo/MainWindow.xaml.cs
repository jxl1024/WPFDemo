using System;
using System.Windows;
using System.Windows.Controls;

namespace InkCanvasDemo
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                // 添加到ComboBox
                this.EditingMode.Items.Add(item);
            }
            this.EditingMode.SelectedIndex = 0;
        }

        private void EditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // 修改InkCanvas的EditingMode属性
            this.inkCanvas.EditingMode =(InkCanvasEditingMode)this.EditingMode.SelectedValue;
        }
    }
}
