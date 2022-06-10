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
    /// Логика взаимодействия для DeletedataGuestcPage.xaml
    /// </summary>
    public partial class DeletedataGuestcPage : Page
    {
        public DeletedataGuestcPage()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данные удалены");
        }
    }
}
