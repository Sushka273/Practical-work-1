using System.Security.Cryptography;
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
using ClassLibrary1;

namespace Практическая_1_Трусов
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

        private void gen(object sender, RoutedEventArgs e)
        {          
            bool f1;
            f1 = Int32.TryParse(zn.Text, out int n);
            if (f1 == true && n > 0)
            {
                n = Convert.ToInt32(zn.Text);
                ch.Text = Class1.Gen(n);
            }
            else MessageBox.Show("Введите правильное значение.");
        }

        private void Ras(object sender, RoutedEventArgs e)
        {
            string r = ch.Text;
            rez.Text = Class1.Ras(r);
        }

        private void Clean(object sender, RoutedEventArgs e)
        {
            rez.Clear();
            ch.Clear();
            zn.Clear();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void about(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сформировать n целых чисел в диапазоне 2 - 14.\nНайти сумму чисел < 8.Результат вывести на экран.");
        }
    }
}