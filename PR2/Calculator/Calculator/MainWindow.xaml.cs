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

namespace Calculator
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

        private void btPlus_Click_1(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Convert.ToDouble(tb1.Text) + Convert.ToDouble(tb2.Text);
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Convert.ToDouble(tb1.Text) - Convert.ToDouble(tb2.Text);
        }

        private void btUmn_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Convert.ToDouble(tb1.Text) * Convert.ToDouble(tb2.Text);
        }

        private void btDel_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Convert.ToDouble(tb1.Text) / Convert.ToDouble(tb2.Text);
        }

        private void btProc_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Convert.ToDouble(tb1.Text) * Convert.ToDouble(tb2.Text) / 100;
        }

        private void btSin_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Math.Sin(Convert.ToDouble(tb1.Text));
        }

        private void btCos_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Math.Cos(Convert.ToDouble(tb1.Text));
        }

        private void btLog_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Math.Log10(Convert.ToDouble(tb1.Text));
        }

        private void btS2_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Math.Pow(Convert.ToDouble(tb1.Text), 2);
        }

        private void btSn_Click(object sender, RoutedEventArgs e)
        {
            lbRes.Content = Math.Pow(Convert.ToDouble(tb1.Text), Convert.ToDouble(tb2.Text));
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            lbRes.Content = "0";
        }
    }
}

    

