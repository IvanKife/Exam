using System.Windows;
using System.Windows.Controls;

namespace Exam.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new ShopPage());
        }
    }
}
