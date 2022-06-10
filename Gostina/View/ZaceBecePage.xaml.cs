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
    /// Логика взаимодействия для ZaceBecePage.xaml
    /// </summary>
    public partial class ZaceBecePage : Page
    {
        Core db = new Core();
        List<Zacebece> arrayZacebece;

        public ZaceBecePage()
        {
            InitializeComponent();
            arrayZacebece = db.context.Zacebece.ToList();

            ZaceBeceDataGrid.ItemsSource = arrayZacebece;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PersonalPage());
        }
    }
}
