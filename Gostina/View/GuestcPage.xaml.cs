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
    /// Логика взаимодействия для GuestcPage.xaml
    /// </summary>
    public partial class GuestcPage : Page
    {
        Core db = new Core();
        List<Zacebece> arrayZacebece;
  
        public GuestcPage()
        {
            InitializeComponent();

            arrayZacebece = db.context.Zacebece.ToList();
            

            GuestcDataGrid.ItemsSource = arrayZacebece;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }

        private void ViewingGuestc_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GuestcInfoPage());
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arrayZacebece = db.context.Zacebece.ToList();

            if (!String.IsNullOrEmpty(FilterTextBox.Text))
            {
                arrayZacebece = arrayZacebece.Where(x => x.Guestc.Surname./*Name*/ToLower().Contains(FilterTextBox.Text.ToLower())).ToList();
            }
            GuestcDataGrid.ItemsSource = arrayZacebece;
        }

        private void СlearingButton_Click(object sender, RoutedEventArgs e)
        {
            var row = GuestcDataGrid.SelectedItem as Guestc;

            if (row == null) 
            {
                MessageBox.Show("Вы не выбрали ни одной строки");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы уверены,что хотите очистить строку", "Очистить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
               
          
             }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DeletedataGuestcPage());
            var row = GuestcDataGrid.SelectedItem as Guestc;

            if (row == null)
            {
                MessageBox.Show("Вы не выбрали ни одной строки");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы уверены,что хотите удалить строку", "Удалить", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {

            }
        }
    }
}
