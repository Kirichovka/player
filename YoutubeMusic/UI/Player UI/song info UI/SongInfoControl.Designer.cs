namespace YoutubeMusic.UI.song_info_UI
{
    partial class SongInfoControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            songPictureBox = new PictureBox();
            songNameLabel = new Label();
            bandNameLabel = new Label();
            additionalInformationPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)songPictureBox).BeginInit();
            SuspendLayout();
            // 
            // songPictureBox
            // 
            songPictureBox.Location = new Point(91, 81);
            songPictureBox.Name = "songPictureBox";
            songPictureBox.Size = new Size(451, 418);
            songPictureBox.TabIndex = 0;
            songPictureBox.TabStop = false;
            // 
            // songNameLabel
            // 
            songNameLabel.AutoSize = true;
            songNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            songNameLabel.ForeColor = Color.White;
            songNameLabel.Location = new Point(91, 517);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(104, 41);
            songNameLabel.TabIndex = 1;
            songNameLabel.Text = "label1";
            // 
            // bandNameLabel
            // 
            bandNameLabel.AutoSize = true;
            bandNameLabel.Font = new Font("Segoe UI", 8F);
            bandNameLabel.ForeColor = SystemColors.ButtonShadow;
            bandNameLabel.Location = new Point(91, 558);
            bandNameLabel.Name = "bandNameLabel";
            bandNameLabel.Size = new Size(71, 30);
            bandNameLabel.TabIndex = 2;
            bandNameLabel.Text = "label1";
            // 
            // additionalInformationPanel
            // 
            additionalInformationPanel.Location = new Point(91, 613);
            additionalInformationPanel.Name = "additionalInformationPanel";
            additionalInformationPanel.Size = new Size(451, 70);
            additionalInformationPanel.TabIndex = 3;
            // 
            // SongInfoControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(additionalInformationPanel);
            Controls.Add(bandNameLabel);
            Controls.Add(songNameLabel);
            Controls.Add(songPictureBox);
            Name = "SongInfoControl";
            Size = new Size(668, 758);
            ((System.ComponentModel.ISupportInitialize)songPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox songPictureBox;
        private Label songNameLabel;
        private Label bandNameLabel;
        private Panel additionalInformationPanel;
    }
}
