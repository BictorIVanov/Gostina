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
    /// Логика взаимодействия для Zabronomer.xaml
    /// </summary>
    public partial class ZabronomerPage : Page
    {
        public ZabronomerPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }

        private void Zabronomirovatnomer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Номер успешно забронирован,ждем вас с нетрепением.Нажмите кнопку назад чтобы вернутся в личный кабинет");
        }
    }
}
