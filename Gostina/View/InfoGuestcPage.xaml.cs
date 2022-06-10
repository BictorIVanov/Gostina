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
    /// Логика взаимодействия для GuestcInfoPage.xaml
    /// </summary>
    public partial class GuestcInfoPage : Page
    {
        Core db = new Core();
        List<Zacebece> arrayZacebece;
        public GuestcInfoPage()
        {
            InitializeComponent();

            arrayZacebece = db.context.Zacebece.ToList();


            InfoGuestcDataGrid.ItemsSource = arrayZacebece;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GuestcPage());

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new DeletedataGuestcPage());
        }

        private void СlearingButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClearingdataGuestcPage());
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arrayZacebece = db.context.Zacebece.ToList();

            if (!String.IsNullOrEmpty(FilterTextBox.Text))
            {
                arrayZacebece = arrayZacebece.Where(x => x.Guestc. Name/*Surname*/.ToLower().Contains(FilterTextBox.Text.ToLower())).ToList();
            }
            InfoGuestcDataGrid.ItemsSource = arrayZacebece;
        }
    }
}
