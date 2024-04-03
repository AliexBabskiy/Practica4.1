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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page3()
        {
            InitializeComponent();
            tablic.ItemsSource = context.Coffee.ToList();
            Cb1.ItemsSource = context.Coffee.ToList();
            Cb2.ItemsSource = context.Coffee.ToList();
        }
        private void poisc(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.Coffee.ToList().Where(item => item.Coffee_Name.Contains(text1.Text));
        }
        private void clearr(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.Coffee.ToList();
        }

        private void Cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as Coffee;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.Coffee == selected);
            }
        }

        private void Cb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb2.SelectedItem != null)
            {
                var selected = Cb2.SelectedItem as Coffee;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.Coffee == selected);
            }
        }
    }
}
