using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Module_9_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int count = 0;
        private void btnClick(object sender, RoutedEventArgs e)
        {
            //Title = $"Button click {count++}";
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Clear text", this.Title,
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Hello {txtName.Text}", this.Title,
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            rect.Fill = Brushes.Black;
            SystemSounds.Beep.Play();
        }

        private void rect_MouseEnter(object sender, MouseEventArgs e)
        {
            rect.Fill= Brushes.Blue;
            SystemSounds.Question.Play();
        }

        private void rect_MouseLeave(object sender, MouseEventArgs e)
        {
            rect.Fill = Brushes.Brown;
            SystemSounds.Hand.Play();
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Button click");
        //}
    }
}
