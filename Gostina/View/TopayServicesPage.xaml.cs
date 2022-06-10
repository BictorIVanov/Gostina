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
    /// Логика взаимодействия для TopayServicesPage.xaml
    /// </summary>
    public partial class TopayServicesPage : Page
    {
        public TopayServicesPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }

        private void Topayservicesrestaurant_Click(object sender, RoutedEventArgs e)
        {
  
            MessageBox.Show("Услуга успешно оплачена.Нажмите кнопку назад чтобы вернутся в личный кабинет");
       
        }
    }
}
