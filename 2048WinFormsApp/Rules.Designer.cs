namespace _2048WinFormsApp
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            rulesLabel = new Label();
            SuspendLayout();
            // 
            // rulesLabel
            // 
            rulesLabel.Dock = DockStyle.Fill;
            rulesLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rulesLabel.Location = new Point(0, 0);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(519, 512);
            rulesLabel.TabIndex = 0;
            rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // Rules
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 512);
            Controls.Add(rulesLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rules";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Правила игры";
            ResumeLayout(false);
        }

        #endregion

        private Label rulesLabel;
    }
}