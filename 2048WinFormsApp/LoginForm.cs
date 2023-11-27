using _2048WinFormsApp.Models;

namespace _2048WinFormsApp
{
    public partial class LoginForm : Form
    {
        public bool isLogon = false;
        public User user;
        public int TilesCount;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            greetingLabel.ForeColor = GameColors.MainTextColor;
            nameLabel.ForeColor = GameColors.MainTextColor;
            nameTextBox.ForeColor = GameColors.MainTextColor;
            chooseTilesCountLabel.ForeColor = GameColors.MainTextColor;
            tilesCountComboBox.ForeColor = GameColors.MainTextColor;
            loginButton.ForeColor = GameColors.ButtonTextColor;
            loginButton.BackColor = GameColors.ButtonColor;

            tilesCountComboBox.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var name = nameTextBox.Text;

                user = new User(name);
                isLogon = true;

                switch (tilesCountComboBox.SelectedIndex)
                {
                    case 0: TilesCount = 4; break;
                    case 1: TilesCount = 5; break;
                    case 2: TilesCount = 6; break;
                }

                Close();
            }
        }

        private void nameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Validation.IsValidateIsNullOrEmpty(nameTextBox, loginFormErrorProvider, e, out string errorMessageIsNullOrEmpty))
            {
                nameValidationLabel.Text = errorMessageIsNullOrEmpty;
                nameValidationLabel.Visible = true;
            }
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }
    }
}
