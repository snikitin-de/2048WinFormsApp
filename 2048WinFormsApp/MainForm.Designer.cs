namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            gameNameLabel = new Label();
            scoreNameLabel = new Label();
            bestScoreNameLabel = new Label();
            scoreLabel = new Label();
            bestScoreLabel = new Label();
            mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            showRulesToolStripMenuItem = new ToolStripMenuItem();
            showGameResultsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            restartToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            greetingLabel = new Label();
            gameHeaderPanel = new Panel();
            mapPanel = new Panel();
            mainMenuStrip.SuspendLayout();
            gameHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gameNameLabel
            // 
            gameNameLabel.Anchor = AnchorStyles.None;
            gameNameLabel.AutoSize = true;
            gameNameLabel.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            gameNameLabel.ForeColor = Color.Black;
            gameNameLabel.Location = new Point(18, 13);
            gameNameLabel.Name = "gameNameLabel";
            gameNameLabel.Size = new Size(176, 75);
            gameNameLabel.TabIndex = 0;
            gameNameLabel.Text = "2048";
            // 
            // scoreNameLabel
            // 
            scoreNameLabel.Anchor = AnchorStyles.None;
            scoreNameLabel.BackColor = SystemColors.ButtonShadow;
            scoreNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreNameLabel.Location = new Point(266, 21);
            scoreNameLabel.Name = "scoreNameLabel";
            scoreNameLabel.Size = new Size(95, 55);
            scoreNameLabel.TabIndex = 1;
            scoreNameLabel.Text = "СЧЕТ";
            scoreNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // bestScoreNameLabel
            // 
            bestScoreNameLabel.Anchor = AnchorStyles.None;
            bestScoreNameLabel.BackColor = SystemColors.ButtonShadow;
            bestScoreNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreNameLabel.Location = new Point(367, 21);
            bestScoreNameLabel.Name = "bestScoreNameLabel";
            bestScoreNameLabel.Size = new Size(108, 55);
            bestScoreNameLabel.TabIndex = 2;
            bestScoreNameLabel.Text = "ЛУЧШИЙ";
            bestScoreNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.None;
            scoreLabel.BackColor = SystemColors.ButtonShadow;
            scoreLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.White;
            scoreLabel.Location = new Point(266, 36);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(95, 38);
            scoreLabel.TabIndex = 3;
            scoreLabel.Text = "0";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bestScoreLabel
            // 
            bestScoreLabel.Anchor = AnchorStyles.None;
            bestScoreLabel.BackColor = SystemColors.ButtonShadow;
            bestScoreLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bestScoreLabel.ForeColor = Color.White;
            bestScoreLabel.Location = new Point(367, 36);
            bestScoreLabel.Name = "bestScoreLabel";
            bestScoreLabel.Size = new Size(108, 38);
            bestScoreLabel.TabIndex = 4;
            bestScoreLabel.Text = "0";
            bestScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(492, 24);
            mainMenuStrip.TabIndex = 5;
            mainMenuStrip.Text = "Меню";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showRulesToolStripMenuItem, showGameResultsToolStripMenuItem, toolStripMenuItem1, restartToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // showRulesToolStripMenuItem
            // 
            showRulesToolStripMenuItem.Name = "showRulesToolStripMenuItem";
            showRulesToolStripMenuItem.Size = new Size(235, 22);
            showRulesToolStripMenuItem.Text = "Просмотреть правила игры";
            showRulesToolStripMenuItem.Click += showRulesToolStripMenuItem_Click;
            // 
            // showGameResultsToolStripMenuItem
            // 
            showGameResultsToolStripMenuItem.Name = "showGameResultsToolStripMenuItem";
            showGameResultsToolStripMenuItem.Size = new Size(235, 22);
            showGameResultsToolStripMenuItem.Text = "Просмотреть результаты игр";
            showGameResultsToolStripMenuItem.Click += showGameResultsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(232, 6);
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(235, 22);
            restartToolStripMenuItem.Text = "Перезапустить игру";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(235, 22);
            exitToolStripMenuItem.Text = "Выйти из игры";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // greetingLabel
            // 
            greetingLabel.Anchor = AnchorStyles.None;
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            greetingLabel.Location = new Point(167, 109);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(135, 22);
            greetingLabel.TabIndex = 6;
            greetingLabel.Text = "Приветствие";
            // 
            // gameHeaderPanel
            // 
            gameHeaderPanel.Controls.Add(gameNameLabel);
            gameHeaderPanel.Controls.Add(bestScoreLabel);
            gameHeaderPanel.Controls.Add(scoreLabel);
            gameHeaderPanel.Controls.Add(greetingLabel);
            gameHeaderPanel.Controls.Add(bestScoreNameLabel);
            gameHeaderPanel.Controls.Add(scoreNameLabel);
            gameHeaderPanel.Location = new Point(0, 27);
            gameHeaderPanel.Name = "gameHeaderPanel";
            gameHeaderPanel.Size = new Size(492, 150);
            gameHeaderPanel.TabIndex = 7;
            // 
            // mapPanel
            // 
            mapPanel.BackColor = SystemColors.Control;
            mapPanel.Location = new Point(0, 175);
            mapPanel.Name = "mapPanel";
            mapPanel.Size = new Size(492, 548);
            mapPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 722);
            Controls.Add(mapPanel);
            Controls.Add(gameHeaderPanel);
            Controls.Add(mainMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            gameHeaderPanel.ResumeLayout(false);
            gameHeaderPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameNameLabel;
        private Label scoreNameLabel;
        private Label bestScoreNameLabel;
        private Label scoreLabel;
        private Label bestScoreLabel;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem showRulesToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label greetingLabel;
        private ToolStripMenuItem showGameResultsToolStripMenuItem;
        private Panel gameHeaderPanel;
        private Panel mapPanel;
    }
}