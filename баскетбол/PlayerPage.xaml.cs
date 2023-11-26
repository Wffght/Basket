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
    /// Логика взаимодействия для PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        NBAShortEntities _context;
        private int _currentPage = 1;
        private int _countPlayrs = 5;
        private int _maxPages;
        
          public PlayerPage()
        {
            InitializeComponent();
            _context = new NBAShortEntities();
            GridPlayres.ItemsSource = _context.PlayerInTeams.ToList();
            CmbSeasons.ItemsSource = _context.Seasons.OrderByDescending(season => season.Name).ToList();
            CmbTeam.ItemsSource = _context.Teams.OrderBy(team => team.TeamName).ToList();
            CmbSeasons.SelectedIndex = 0;
            CmbTeam.SelectedIndex = 0;
            RefreshPlayers();

        }

        private void RefreshPlayers()
        {
            Team selectedTeam = CmbTeam.SelectedItem as Team;
            Season selectedSeason = CmbSeasons.SelectedItem as Season;
            string searchText = TxtPlayerName.Text;
            List<PlayerInTeam> listPlayers = _context.PlayerInTeams.ToList();
            listPlayers = listPlayers.Where(x => x.Season == selectedSeason).ToList();
            listPlayers = listPlayers.Where(x => x.Team == selectedTeam).ToList();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                listPlayers = listPlayers.Where(x => x.Player.Name.ToLower().Contains(searchText.ToLower())).ToList();
            }
         
            listPlayers = listPlayers.OrderBy(x => x.ShirtNumber).ToList();
            GridPlayres.ItemsSource = listPlayers;
            _maxPages = (int)Math.Ceiling(listPlayers.Count * 1.0 / _countPlayrs);

            var listPlayersInPage = listPlayers.Skip((_currentPage - 1) * _countPlayrs).Take(_countPlayrs).ToList();
            TxtCurrentPage.Text = _currentPage.ToString();
            LblTotalPages.Content = "of" + _maxPages;
            LblSummaryInfo.Content = $"Total {listPlayers.Count} records, { _countPlayrs} records in one page ";
            GridPlayres.ItemsSource = listPlayersInPage;
        }

        private void CmbSeasons_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshPlayers();
        }

        private void CmbTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshPlayers();
        }

        private void TxtPlayerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshPlayers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            _currentPage = 1;
            RefreshPlayers();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_currentPage == 1)
            {
                _currentPage = 1;
            }
            else {
                _currentPage--;
            }
                RefreshPlayers();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (_currentPage == _maxPages)
            {
                _currentPage = _maxPages;
            }
            else
            {
                _currentPage++;
            }
           
            RefreshPlayers();
 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _currentPage = _maxPages;
            RefreshPlayers();

        }
    }
}
