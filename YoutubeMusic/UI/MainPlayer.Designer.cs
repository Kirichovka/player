namespace YoutubeMusic
{
    partial class MainPlayer
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
            PlayerTableLayoutPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // PlayerTableLayoutPanel
            // 
            PlayerTableLayoutPanel.BackColor = Color.Transparent;
            PlayerTableLayoutPanel.ColumnCount = 1;
            PlayerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlayerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PlayerTableLayoutPanel.Location = new Point(-3, -1);
            PlayerTableLayoutPanel.Name = "PlayerTableLayoutPanel";
            PlayerTableLayoutPanel.RowCount = 4;
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82.55114F));
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.4488564F));
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            PlayerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            PlayerTableLayoutPanel.Size = new Size(670, 944);
            PlayerTableLayoutPanel.TabIndex = 0;
            // 
            // MainPlayer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(664, 944);
            Controls.Add(PlayerTableLayoutPanel);
            Name = "MainPlayer";
            Text = "Player";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PlayerTableLayoutPanel;
    }
}
