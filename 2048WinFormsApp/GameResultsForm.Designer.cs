namespace _2048WinFormsApp
{
    partial class GameResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameResultsForm));
            gameResultsDataGridView = new DataGridView();
            UserNameColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gameResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // gameResultsDataGridView
            // 
            gameResultsDataGridView.AllowUserToAddRows = false;
            gameResultsDataGridView.AllowUserToDeleteRows = false;
            gameResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gameResultsDataGridView.BorderStyle = BorderStyle.None;
            gameResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameResultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { UserNameColumn, ScoreColumn });
            gameResultsDataGridView.Dock = DockStyle.Fill;
            gameResultsDataGridView.Location = new Point(0, 0);
            gameResultsDataGridView.Name = "gameResultsDataGridView";
            gameResultsDataGridView.RowTemplate.Height = 25;
            gameResultsDataGridView.Size = new Size(800, 450);
            gameResultsDataGridView.TabIndex = 0;
            // 
            // UserNameColumn
            // 
            UserNameColumn.HeaderText = "Пользователь";
            UserNameColumn.Name = "UserNameColumn";
            // 
            // ScoreColumn
            // 
            ScoreColumn.HeaderText = "Набранное количество очков";
            ScoreColumn.Name = "ScoreColumn";
            // 
            // GameResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gameResultsDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameResultsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "2048 • Результаты игр";
            Load += GameResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)gameResultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gameResultsDataGridView;
        private DataGridViewTextBoxColumn UserNameColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
    }
}