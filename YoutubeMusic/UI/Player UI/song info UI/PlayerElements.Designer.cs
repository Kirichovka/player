namespace YoutubeMusic.UI.Player_UI
{
    partial class PlayerElements
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
            backPlayerButton = new Button();
            playPlayerButton = new Button();
            forwardPlayerButton = new Button();
            seekBarPanel = new Panel();
            SuspendLayout();
            // 
            // backPlayerButton
            // 
            backPlayerButton.Location = new Point(130, 73);
            backPlayerButton.Name = "backPlayerButton";
            backPlayerButton.Size = new Size(81, 73);
            backPlayerButton.TabIndex = 0;
            backPlayerButton.Text = "Back";
            backPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playPlayerButton
            // 
            playPlayerButton.Location = new Point(249, 53);
            playPlayerButton.Name = "playPlayerButton";
            playPlayerButton.Size = new Size(116, 110);
            playPlayerButton.TabIndex = 1;
            playPlayerButton.Text = "Play";
            playPlayerButton.UseVisualStyleBackColor = true;
            // 
            // forwardPlayerButton
            // 
            forwardPlayerButton.Location = new Point(401, 73);
            forwardPlayerButton.Name = "forwardPlayerButton";
            forwardPlayerButton.Size = new Size(81, 73);
            forwardPlayerButton.TabIndex = 2;
            forwardPlayerButton.Text = "Back";
            forwardPlayerButton.UseVisualStyleBackColor = true;
            // 
            // seekBarPanel
            // 
            seekBarPanel.Location = new Point(91, 15);
            seekBarPanel.Name = "seekBarPanel";
            seekBarPanel.Size = new Size(648, 10);
            seekBarPanel.TabIndex = 4;
            // 
            // PlayerElements
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(seekBarPanel);
            Controls.Add(forwardPlayerButton);
            Controls.Add(playPlayerButton);
            Controls.Add(backPlayerButton);
            Name = "PlayerElements";
            Size = new Size(795, 279);
            ResumeLayout(false);
        }

        #endregion

        private Button backPlayerButton;
        private Button playPlayerButton;
        private Button forwardPlayerButton;
        private Panel seekBarPanel;
    }
}
