using _2048WinFormsApp.Models;

namespace _2048WinFormsApp
{
    internal class GameResultStorage
    {
        private string gameResultSavings = "gameResult.json";
        private List<GameResult> gameResults = new List<GameResult>();
        private JsonSerializer jsonSerializer;

        public GameResultStorage()
        {
            jsonSerializer = new JsonSerializer(gameResultSavings);
            gameResults = Read();
        }

        public void Add(GameResult gameResult)
        {
            gameResults.Add(gameResult);
            jsonSerializer.Add(gameResults);
        }

        public List<GameResult> Read()
        {
            return jsonSerializer.Read<GameResult>();
        }

        public int GetBestScore()
        {
            if (gameResults.Count != 0)
            {
                return gameResults.Max(x => x.Score);
            }
            else
            {
                return 0;
            }
        }
    }
}
