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
    /// Логика взаимодействия для Pages.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        Core db = new Core();
        List<Guestc> Guestc;
        public AuthPage()
        {
            InitializeComponent();
            Guestc = db.context.Guestc.ToList();
        }

     

        private void NavButtonClick(object sender, RoutedEventArgs e)
        {
            //
            if(
                LoginTextBox.Text != String.Empty
                && PadPasswordBox.Password != String.Empty
                && !String.IsNullOrWhiteSpace(LoginTextBox.Text)
                && !String.IsNullOrWhiteSpace(PadPasswordBox.Password)
                )
            {
                //
                int countRecord = Guestc
               .Where(x => x.Login == LoginTextBox.Text && x.Password == PadPasswordBox.Password)
               .Count();
                if (countRecord == 1)
                {
                    this.NavigationService.Navigate(new PersonalPage());
                }
                else
                {
                    MessageBox.Show("Не введен логин или пароль");
                }
            }
                
        }

        private void RisiTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.Navigate(new RisitraciaPage ());
        }
    }
        
}

