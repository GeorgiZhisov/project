using System.Diagnostics;
using System.Numerics;

namespace _02_Project_Tennis_Score_App
{
    public partial class ScoreForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new Dictionary<string, int>()
        {
            { "R. Federer", 4 },
            { "G. Dimitrov", 5 },
            { "R. Nadal", 5 },
        };

        private static Dictionary<(string, int), List<(string, int)>> games = new Dictionary<(string, int), List<(string, int)>>()
        {
            { ("G. Dimitrov", 3), new List<(string, int)>() { ("R. Nadal", 2) } },
            { ("R. Nadal", 3), new List<(string, int)>() { ("R. Federer", 1) } },
            { ("G. Dimitrov", 2), new List<(string, int)>() { ("R. Federer", 3) } },
        };

        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            FillRangingListView();
            FillLatestGamesListView();
        }

        private void FillLatestGamesListView()
        {
            this.listViewLatestGames.Items.Clear();

            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }

        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            var item = new ListViewItem();
            item.SubItems[0].Text = firstPlayer.Item1;
            item.SubItems.Add(secondPlayer.Item1);
            item.SubItems.Add(winner);
            item.SubItems.Add($"{firstPlayer.Item2} : {secondPlayer.Item2}");

            this.listViewLatestGames.Items.Add(item);

        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }

            return "Draw";
        }

        private void FillRangingListView()
        {
            this.listViewRankings.Items.Clear();

            foreach (var player in playersWithPoints)
            {
                string playerName = player.Key;
                string playerPoints = $"{player.Value}";

                var item = new ListViewItem();
                item.SubItems[0].Text = playerName;
                item.SubItems.Add(playerPoints);

                this.listViewRankings.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRangingListView();
            FillLatestGamesListView();

        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer))
            {
                games[firstPlayer].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer))
            {
                games[secondPlayer].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer, new List<(string, int)>() { secondPlayer });
            }
        }

        private void listViewRankings_Click(object sender, EventArgs e)
        {
            var selectedRow = this.listViewRankings.SelectedItems[0];
            var playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;

            using (var playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
            => games.Where(x => x.Key.Item1 == playerName
                || x.Value.Any(y => y.Item1 == playerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName
                || x.Value.Any(y => y.Item1 == playerName))
            .ToList());
    }
}
