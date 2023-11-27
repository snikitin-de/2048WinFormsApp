namespace _2048WinFormsApp.Models
{
    public class GameResult
    {
        public User User { get; set; }
        public int Score { get; set; }

        public GameResult(User user, int score)
        {
            User = user;
            Score = score;
        }
    }
}
