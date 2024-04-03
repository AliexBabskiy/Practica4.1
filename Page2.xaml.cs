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

namespace PrPract4._1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page2()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Client.ToList();
            Cb1.ItemsSource = context.EMP.ToList();
        }
        private void poisc(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.Client.ToList().Where(item => item.ClientName.Contains(text1.Text));
        }
        private void clearr(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.Client.ToList();
        }

        private void Cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as Client;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.Client == selected);
            }
        }
    }
}
