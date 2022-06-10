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
    /// Логика взаимодействия для RedactorPage.xaml
    /// </summary>
    public partial class RedactorPage : Page
    {
        public RedactorPage()
        {
            InitializeComponent();
        }

        private void SavButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные сохранены");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }
    }
}
