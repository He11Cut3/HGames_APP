using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HGames.UC
{
    public partial class Game_UC : UserControl
    {
        public ObservableCollection<Game> Games { get; set; }
        public Game_UC()
        {
            InitializeComponent();
            Games = new ObservableCollection<Game>();
            LV_Game.ItemsSource = Games;
            LoadGameData();
        }
        public async Task<Game> GetGameAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7122/api/HGames/");
                HttpResponseMessage response = await client.GetAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Game game = JsonConvert.DeserializeObject<Game>(json);
                    return game;
                }
                else
                {
                    MessageBox.Show("Error fetching game data.");
                    return null;
                }
            }
        }


        private async void LoadGameData()
        {
            for(int i = 1; i < 500; i++)
            {
                var game = await GetGameAsync(i);
                if (game != null)
                {
                    Games.Add(game);
                    LV_Game.ItemsSource = Games;
                }
            }
            
        }

        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (sender is Border border && border.DataContext is Game item)
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = item.Url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось открыть URL: {ex.Message}");
                }
            }
        }
    }
}
