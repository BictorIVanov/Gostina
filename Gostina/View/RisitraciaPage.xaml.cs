using Gostina.Controllers;
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
    /// Логика взаимодействия для Risitracia.xaml
    /// </summary>
    public partial class RisitraciaPage : Page
    {
        public RisitraciaPage()
        {
            InitializeComponent();
        }


        private void RisitriaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Регистрация новых постояльцев временно недоступна");
        //    GuestcControllers newObject = new GuestcControllers();
        //    bool result = newObject.AddGuestcInfo(NameTexiBox.Text, SurnameTextBox.Text, FatherlandTextBox, Convert.ToDateTime(BirhtdayDatePicker.SelectedDate.Value),
        //        NumberPassportTextBox.Text, NumberSeriaTextBox, LoginTextBox, PasswordTextBox.text);
        //    if (result)

        //    {
        //        MessageBox.Show("Добавление выплнено успешно!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AuthPage());
        }
    }
}
