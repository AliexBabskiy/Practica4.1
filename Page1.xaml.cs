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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private BdPracticaEntities context = new BdPracticaEntities();
        public Page1()
        {
            InitializeComponent();
            tablic.ItemsSource = context.EMP.ToList();
            Cb1.ItemsSource = context.EMP.ToList();
            Cb2.ItemsSource = context.EMP.ToList();
            Cb3.ItemsSource = context.EMP.ToList();
        }

        private void poisc(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.EMP.ToList().Where(item => item.SURNAME.Contains(text1.Text))
                .Where(item => item.FIRST_NAME.Contains(text2.Text))
                .Where(item => item.MIDDLENAME.Contains(text3.Text));
        }

        private void clearr(object sender, RoutedEventArgs e)
        {
            tablic.ItemsSource = context.EMP.ToList();
        }

        private void Cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb1.SelectedItem != null)
            {
                var selected = Cb1.SelectedItem as EMP;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.EMP == selected);
            }
        }

        private void Cb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb2.SelectedItem != null)
            {
                var selected = Cb2.SelectedItem as EMP;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.EMP == selected);
            }
        }

        private void Cb3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb3.SelectedItem != null)
            {
                var selected = Cb3.SelectedItem as EMP;
                tablic.ItemsSource = context.ConnectId.ToList().Where(item => item.EMP == selected);
            }
        }
    }
}
