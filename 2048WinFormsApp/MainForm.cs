using _2048WinFormsApp.Models;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;
        private int tilesCount = 4;
        private int mapBorderPadding = 100;
        private GameResultStorage gameResultsStorage;
        public static User User;
        public static int bestScore;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            gameResultsStorage = new GameResultStorage();

            BackColor = GameColors.GameBackgroundColor;
            gameNameLabel.ForeColor = GameColors.MainTextColor;
            scoreLabel.ForeColor = GameColors.ScoreFontColor;
            scoreLabel.BackColor = GameColors.ScoreBackgroundColor;
            scoreNameLabel.ForeColor = GameColors.ScoreNameFontColor;
            scoreNameLabel.BackColor = GameColors.ScoreBackgroundColor;
            bestScoreLabel.ForeColor = GameColors.ScoreFontColor;
            bestScoreLabel.BackColor = GameColors.ScoreBackgroundColor;
            bestScoreNameLabel.ForeColor = GameColors.ScoreNameFontColor;
            bestScoreNameLabel.BackColor = GameColors.ScoreBackgroundColor;

            bestScore = gameResultsStorage.GetBestScore();
            bestScoreLabel.Text = bestScore.ToString();

            var mapLocation = new Point(0, 0);
            ChangeUser();
            game = new Game(mapLocation, tilesCount);
            var map = game.GetMap();
            var mapTiles = map.Get();

            mapPanel.Width = map.GetSize();
            gameHeaderPanel.Width = map.GetSize();
            mapPanel.Height = map.GetSize();
            mapPanel.BackColor = GameColors.BackgroundColor;

            for (int i = 0; i < tilesCount; i++)
            {
                for (int j = 0; j < tilesCount; j++)
                {
                    var x = map.TileGap + j * (map.TileSize + map.TileGap);
                    var y = map.TileGap + i * (map.TileSize + map.TileGap);

                    var tile = mapTiles[i, j];
                    tile.Location = new Point(x, y);

                    mapPanel.Controls.Add(tile);
                }
            }

            ColorMap(mapTiles);

            Height = mapPanel.Height + gameHeaderPanel.Height + 64;
            Width = mapPanel.Width + 16;

            mapPanel.Anchor = AnchorStyles.None;
            gameHeaderPanel.Anchor = AnchorStyles.None;

            Height += mapBorderPadding;
            Width += mapBorderPadding;

            MinimumSize = new Size(Width, Height);

            Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
            Top = Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            var map = game.GetMap();
            var mapTiles = map.Get();

            switch (e.KeyCode)
            {
                case Keys.Right: game.MoveRight(); break;
                case Keys.Left: game.MoveLeft(); break;
                case Keys.Up: game.MoveUp(); break;
                case Keys.Down: game.MoveDown(); break;
            }

            ColorMap(mapTiles);

            var score = game.GetScore();
            scoreLabel.Text = score.ToString();
            bestScoreLabel.Text = bestScore < score ? score.ToString() : bestScore.ToString();
        }

        private void showRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new Rules();
            rulesForm.BackColor = GameColors.GameBackgroundColor;
            rulesForm.ShowDialog();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeUser()
        {
            var loginForm = new LoginForm();
            loginForm.BackColor = GameColors.GameBackgroundColor;
            loginForm.Width = Width;
            loginForm.Height = Height;
            loginForm.Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
            loginForm.Top = Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2;
            loginForm.MinimumSize = new Size(Width, Height);
            loginForm.ShowDialog();

            if (loginForm.isLogon)
            {
                User = loginForm.user;
                greetingLabel.Text = $"{User.Name}, добро пожаловать в игру!";
                greetingLabel.Left = gameHeaderPanel.Width / 2 - greetingLabel.Width / 2 - 5;
                greetingLabel.ForeColor = GameColors.MainTextColor;

                tilesCount = loginForm.TilesCount;

                Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (game != null)
            {
                var score = game.GetScore();
                var gameResult = new GameResult(User, score);

                gameResultsStorage.Add(gameResult);
            }
        }

        private void showGameResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();

            var gameResultsForm = new GameResultsForm();
            gameResultsForm.Width = Width;
            gameResultsForm.Height = Height;
            gameResultsForm.Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
            gameResultsForm.Top = Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2;
            gameResultsForm.ShowDialog();

            Show();
        }

        private void ColorMap(Label[,] mapTiles)
        {
            for (int i = 0; i < tilesCount; i++)
            {
                for (int j = 0; j < tilesCount; j++)
                {
                    var tile = mapTiles[i, j];
                    var tileNumber = tile.Text == string.Empty ? -1 : Convert.ToInt32(tile.Text);

                    switch (tileNumber)
                    {
                        case 2: tile.BackColor = GameColors.Tile2BackgroundColor; tile.ForeColor = GameColors.TileDarkColor; tile.Font = GameFonts.TileLargeFont;  break;
                        case 4: tile.BackColor = GameColors.Tile4BackgroundColor; tile.ForeColor = GameColors.TileDarkColor; tile.Font = GameFonts.TileLargeFont; break;
                        case 8: tile.BackColor = GameColors.Tile8BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileLargeFont; break;
                        case 16: tile.BackColor = GameColors.Tile16BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileLargeFont; break;
                        case 32: tile.BackColor = GameColors.Tile32BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileLargeFont; break;
                        case 64: tile.BackColor = GameColors.Tile64BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileLargeFont; break;
                        case 128: tile.BackColor = GameColors.Tile128BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileMediumFont; break;
                        case 256: tile.BackColor = GameColors.Tile256BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileMediumFont; break;
                        case 512: tile.BackColor = GameColors.Tile512BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileMediumFont; break;
                        case 1024: tile.BackColor = GameColors.Tile1024BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileSmallFont; break;
                        case 2048: tile.BackColor = GameColors.Tile2048BackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileSmallFont; break;
                        case > 2048: tile.BackColor = GameColors.TileOtherBackgroundColor; tile.ForeColor = GameColors.TileLightColor; tile.Font = GameFonts.TileSmallFont; break;
                        default: tile.BackColor = GameColors.TileBackgroundColor; break;
                    }
                }
            }
        }
    }
}