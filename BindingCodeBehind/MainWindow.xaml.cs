using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingCodeBehind
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

        private void addTextBox_Click(object sender, RoutedEventArgs e)
        {
            TextBox newTextBlock = new TextBox();
            newTextBlock.Text="just added";
            
            
            newTextBlock.SetBinding(TextBox.TextProperty, new Binding("Testo") { Source = DataContext as MainWindowViewModel });
            stackP.Children.Add(newTextBlock);
        }
    }
}
