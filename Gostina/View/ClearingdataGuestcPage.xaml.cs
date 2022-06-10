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
    /// Логика взаимодействия для ClearingdataGuestcPage.xaml
    /// </summary>
    public partial class ClearingdataGuestcPage : Page
    {
        public ClearingdataGuestcPage()
        {
            InitializeComponent();
           // this.content = context;

           // GuestcComboBox.ItemsSource =  context.Guestc.ToList();

           //GostnomerComboBox.ItemsSource = context.Gostnomer.ToList();
        }

        private void ClearingButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные очищены");
        }
    }
}
