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
    /// Логика взаимодействия для ServicesPage.xaml
    /// </summary>
    public partial class ServicesPage : Page
    {
        Core db = new Core();
        List<Services> arrayServices;
        public ServicesPage()
        {
            InitializeComponent();
            ServicesListView.ItemsSource = db.context.Services.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }

        private void Orenservices_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TopayServicesPage());
        }

 

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            arrayServices = db.context.Services.ToList();

            if (!String.IsNullOrEmpty(FilterTextBox.Text))
            {
                arrayServices = arrayServices.Where(x => x.Cost.ToLower().Contains(FilterTextBox.Text.ToLower())).ToList();
            }
            ServicesListView.ItemsSource = arrayServices;
        }

    
       
    }
}
