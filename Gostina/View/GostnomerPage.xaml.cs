using Gostina.Model;
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

namespace Gostina.View
{
    /// <summary>
    /// Логика взаимодействия для GostNomer.xaml
    /// </summary>
    public partial class GostNomerPage : Page
    {
        Core db = new Core();
        List<Gostnomer> arrayGostnomer;
        public GostNomerPage()
        {
            InitializeComponent();
            GostnomeraListView.ItemsSource = db.context.Gostnomer.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }

        private void Opennomer_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ZabronomerPage());
        }

   

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arrayGostnomer = db.context.Gostnomer.ToList();

            if (!String.IsNullOrEmpty(FilterTextBox.Text))
            {
                arrayGostnomer = arrayGostnomer.Where(x => x.Numbernomer/*Numberrooms*/.ToLower().Contains(FilterTextBox.Text.ToLower())).ToList();
            }
            GostnomeraListView.ItemsSource = arrayGostnomer;
        }
    }
}
