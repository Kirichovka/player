namespace YoutubeMusic.UI.PlayList_UI
{
    partial class PlayList
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
            PlayListlistBox = new ListBox();
            SuspendLayout();
            // 
            // PlayListlistBox
            // 
            PlayListlistBox.BackColor = Color.Black;
            PlayListlistBox.ForeColor = Color.White;
            PlayListlistBox.FormattingEnabled = true;
            PlayListlistBox.Location = new Point(-8, -2);
            PlayListlistBox.Name = "PlayListlistBox";
            PlayListlistBox.Size = new Size(678, 932);
            PlayListlistBox.TabIndex = 0;
            // 
            // PlayList
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PlayListlistBox);
            Name = "PlayList";
            Size = new Size(670, 944);
            ResumeLayout(false);
        }

        #endregion

        private ListBox PlayListlistBox;
    }
}
