namespace _2048WinFormsApp
{
    public partial class GameResultsForm : Form
    {
        public GameResultsForm()
        {
            InitializeComponent();
        }

        private void GameResultsForm_Load(object sender, EventArgs e)
        {
            var gameResultsStorage = new GameResultStorage();
            var gameResults = gameResultsStorage.Read();

            gameResults = gameResults.OrderByDescending(x => x.Score).ToList();

            foreach (var gameResult in gameResults)
            {
                var userName = gameResult.User.Name;
                var score = gameResult.Score;

                gameResultsDataGridView.Rows.Add(userName, score);
            }
        }
    }
}
