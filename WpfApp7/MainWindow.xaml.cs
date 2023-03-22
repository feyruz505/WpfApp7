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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
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


        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            string[] words = nametxt.Text.Split(' ');
            string[] words2 = surnametxt.Text.Split(' ');
            string[] words3 = dateTime.Text.Split(' ');

            foreach (string word in words)
            {
                string inputText = nametxt.Text;

                if (!string.IsNullOrEmpty(inputText))
                {
                    TextBlock mytextBlock = new TextBlock();
                    mytextBlock.Background = new SolidColorBrush(Colors.White);

                    mytextBlock.Name = "myTextBlock";
                    cedvel.Items.Add($"{nametxt.Text}    {surnametxt.Text}     {dateTime.Text}");
                }
            }
        }

        private void Button_Click_Delet(object sender, RoutedEventArgs e)
        {
            cedvel.Items.Remove(cedvel.SelectedItem);
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            cedvel.Items.Clear();
        }
    }
}
