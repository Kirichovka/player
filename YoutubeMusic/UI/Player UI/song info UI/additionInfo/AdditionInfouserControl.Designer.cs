namespace YoutubeMusic.UI.song_info_UI.additionInfo
{
    partial class AdditionInfouserControl
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
            likesButton = new Button();
            commnetsButton = new Button();
            saveButton = new Button();
            shareButton = new Button();
            DownloadButton = new Button();
            radioButton = new Button();
            SuspendLayout();
            // 
            // likesButton
            // 
            likesButton.Location = new Point(0, 0);
            likesButton.Name = "likesButton";
            likesButton.Size = new Size(179, 70);
            likesButton.TabIndex = 0;
            likesButton.Text = "Likes";
            likesButton.UseVisualStyleBackColor = true;
            // 
            // commnetsButton
            // 
            commnetsButton.Location = new Point(198, 0);
            commnetsButton.Name = "commnetsButton";
            commnetsButton.Size = new Size(132, 70);
            commnetsButton.TabIndex = 1;
            commnetsButton.Text = "comments";
            commnetsButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(335, 0);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(130, 70);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // shareButton
            // 
            shareButton.Location = new Point(471, 0);
            shareButton.Name = "shareButton";
            shareButton.Size = new Size(130, 70);
            shareButton.TabIndex = 3;
            shareButton.Text = "Share";
            shareButton.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(607, 3);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(130, 70);
            DownloadButton.TabIndex = 4;
            DownloadButton.Text = "Download";
            DownloadButton.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            radioButton.Location = new Point(743, 0);
            radioButton.Name = "radioButton";
            radioButton.Size = new Size(130, 70);
            radioButton.TabIndex = 5;
            radioButton.Text = "Radio";
            radioButton.UseVisualStyleBackColor = true;
            // 
            // AdditionInfouserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radioButton);
            Controls.Add(DownloadButton);
            Controls.Add(shareButton);
            Controls.Add(saveButton);
            Controls.Add(commnetsButton);
            Controls.Add(likesButton);
            Name = "AdditionInfouserControl";
            Size = new Size(919, 70);
            ResumeLayout(false);
        }

        #endregion

        private Button likesButton;
        private Button commnetsButton;
        private Button saveButton;
        private Button shareButton;
        private Button DownloadButton;
        private Button radioButton;
    }
}
