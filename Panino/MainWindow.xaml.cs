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

namespace Panino
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double somma = 0.00;
            if (rdb_Normale.IsChecked == true)

                somma += 3;

            else if (rdb_Integrale.IsChecked == true)

                somma += 4;

            else
                somma += 3.50;
            if (rdb_Prosciutto.IsChecked == true)

                somma += 4;

            else if (rdb_Salsiccia.IsChecked == true)
                somma += 4.50;
            else
                somma += 3.50;
            if (chk_Insalata.IsChecked == true)
                somma += 1;
            if (chk_Formaggio.IsChecked == true)
                somma += 2;
            if (chk_Peperoni.IsChecked == true)
                somma += 4;
            if (chk_Cipolla.IsChecked == true)
                somma += 3;
            lbl_Totale.Content = somma.ToString();
        }
    }
}
