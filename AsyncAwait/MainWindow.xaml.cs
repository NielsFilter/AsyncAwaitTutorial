using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using ExternalDependency;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ExternalCall _ec;

        public MainWindow()
        {
            InitializeComponent();
            _ec = new ExternalCall();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var counter = int.Parse(tbClickCounter.Text) + 1;
            tbClickCounter.Text = counter.ToString();
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            var luckyNumber = _ec.GetLuckyNumber();
            tbResult.Text = "Done! Your lucky number is: " + luckyNumber;
        }
    }
}
