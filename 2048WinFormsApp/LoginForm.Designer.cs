namespace _2048WinFormsApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            loginButton = new Button();
            greetingLabel = new Label();
            loginFormErrorProvider = new ErrorProvider(components);
            nameValidationLabel = new Label();
            tilesCountComboBox = new ComboBox();
            chooseTilesCountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)loginFormErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(299, 121);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(51, 24);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameTextBox.Location = new Point(356, 119);
            nameTextBox.MaximumSize = new Size(350, 0);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(230, 29);
            nameTextBox.TabIndex = 3;
            nameTextBox.KeyDown += nameTextBox_KeyDown;
            nameTextBox.Validating += nameTextBox_Validating;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(251, 243);
            loginButton.Margin = new Padding(3, 15, 3, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(183, 58);
            loginButton.TabIndex = 6;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // greetingLabel
            // 
            greetingLabel.Anchor = AnchorStyles.None;
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            greetingLabel.Location = new Point(137, 59);
            greetingLabel.Margin = new Padding(3, 0, 3, 15);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(411, 29);
            greetingLabel.TabIndex = 7;
            greetingLabel.Text = "Добро пожаловать в игру \"2048\"!";
            // 
            // loginFormErrorProvider
            // 
            loginFormErrorProvider.ContainerControl = this;
            // 
            // nameValidationLabel
            // 
            nameValidationLabel.Anchor = AnchorStyles.None;
            nameValidationLabel.AutoSize = true;
            nameValidationLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameValidationLabel.ForeColor = Color.Red;
            nameValidationLabel.Location = new Point(356, 151);
            nameValidationLabel.Name = "nameValidationLabel";
            nameValidationLabel.Size = new Size(111, 15);
            nameValidationLabel.TabIndex = 8;
            nameValidationLabel.Text = "Валидация имени";
            nameValidationLabel.Visible = false;
            // 
            // tilesCountComboBox
            // 
            tilesCountComboBox.Anchor = AnchorStyles.None;
            tilesCountComboBox.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tilesCountComboBox.FormattingEnabled = true;
            tilesCountComboBox.Items.AddRange(new object[] { "4x4", "5x5", "6x6" });
            tilesCountComboBox.Location = new Point(356, 180);
            tilesCountComboBox.Name = "tilesCountComboBox";
            tilesCountComboBox.Size = new Size(230, 30);
            tilesCountComboBox.TabIndex = 9;
            // 
            // chooseTilesCountLabel
            // 
            chooseTilesCountLabel.Anchor = AnchorStyles.None;
            chooseTilesCountLabel.AutoSize = true;
            chooseTilesCountLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            chooseTilesCountLabel.Location = new Point(99, 182);
            chooseTilesCountLabel.Name = "chooseTilesCountLabel";
            chooseTilesCountLabel.Size = new Size(251, 24);
            chooseTilesCountLabel.TabIndex = 10;
            chooseTilesCountLabel.Text = "Выберите размер поля";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(chooseTilesCountLabel);
            Controls.Add(tilesCountComboBox);
            Controls.Add(nameValidationLabel);
            Controls.Add(greetingLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(loginButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048 • Авторизация";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)loginFormErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Button loginButton;
        private Label greetingLabel;
        private ErrorProvider loginFormErrorProvider;
        private Label nameValidationLabel;
        private Label chooseTilesCountLabel;
        private ComboBox tilesCountComboBox;
    }
}