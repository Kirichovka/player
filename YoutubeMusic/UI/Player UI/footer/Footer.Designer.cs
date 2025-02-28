namespace YoutubeMusic.UI.Player_UI.footer
{
    partial class Footer
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
            PlayerButton = new Button();
            PlayListButton = new Button();
            SuspendLayout();
            // 
            // PlayerButton
            // 
            PlayerButton.Location = new Point(15, 38);
            PlayerButton.Name = "PlayerButton";
            PlayerButton.Size = new Size(118, 64);
            PlayerButton.TabIndex = 0;
            PlayerButton.Text = "Player";
            PlayerButton.UseVisualStyleBackColor = true;
            PlayerButton.Click += PlayerButton_Click;
            // 
            // PlayListButton
            // 
            PlayListButton.BackColor = Color.Transparent;
            PlayListButton.Location = new Point(531, 38);
            PlayListButton.Name = "PlayListButton";
            PlayListButton.Size = new Size(118, 64);
            PlayListButton.TabIndex = 1;
            PlayListButton.Text = "Play List";
            PlayListButton.UseVisualStyleBackColor = false;
            PlayListButton.Click += PlayListButton_Click;
            // 
            // Footer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PlayListButton);
            Controls.Add(PlayerButton);
            Name = "Footer";
            Size = new Size(697, 102);
            ResumeLayout(false);
        }

        #endregion

        private Button PlayerButton;
        private Button PlayListButton;
    }
}
