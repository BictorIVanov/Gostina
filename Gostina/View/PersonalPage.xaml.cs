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
    /// Логика взаимодействия для PersonalPage.xaml
    /// </summary>
    public partial class PersonalPage : Page
    {
        public PersonalPage()
        {
            InitializeComponent();
        }

        private void FiriGuestc_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GuestcPage());
        }

        private void ViriGostnomer_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GostNomerPage());
        }
        private void RifiZacebece_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ZaceBecePage());
        }

        private void VareServices_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ServicesPage());
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthPage());
        }

        private void Redactor_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RedactorPage());
        }

        private void Aboutme_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AboutmePage());
        }

        //private void FiniInfoSyste_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
