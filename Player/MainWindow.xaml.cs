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

namespace Player
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Proxima_Click(object sender, RoutedEventArgs e)
        {
            if (c1.Offset >= 0)
            {
                c1.Offset -= 0.01;
                c2.Offset -= 0.01;
            }
            else
            {
                c1.Offset = 1;
                c2.Offset = 0.89;
            }
        }

        private void Anterior_Click(object sender, RoutedEventArgs e)
        {
            if (c2.Offset <= 1)
            {
                c1.Offset += 0.01;
                c2.Offset += 0.01;
            }
            else
            {
                c1.Offset = 0.11;
                c2.Offset = 0;
            }
        }
    }
}
