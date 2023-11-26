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

namespace баскетбол
{
    /// <summary>
    /// Логика взаимодействия для VisitorMenu.xaml
    /// </summary>
    public partial class VisitorMenu : Page
    {
        public VisitorMenu()
        {
            InitializeComponent();
        }

        private void Teams_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Players_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlayerPage());
        }

        private void Photos_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Matchups_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MatchupList());
        }
    }
}
