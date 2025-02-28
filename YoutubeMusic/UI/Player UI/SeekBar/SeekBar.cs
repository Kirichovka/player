using System;
using System.Drawing;
using System.Windows.Forms;

public class SeekBar : Panel
{
    private float progress = 0.0f;
    private float buffered = 0.0f;

    public SeekBar()
    {
        this.DoubleBuffered = true;
        this.Height = 10;
        this.Dock = DockStyle.Bottom;
        this.BackColor = Color.Black;

        this.MouseDown += SeekBar_MouseDown;
    }

    public void SetProgress(float value)
    {
        progress = Math.Max(0, Math.Min(1, value));
        this.Invalidate();
    }

    public void SetBuffered(float value)
    {
        buffered = Math.Max(0, Math.Min(1, value));
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics g = e.Graphics;

        using (Brush bufferBrush = new SolidBrush(Color.Gray))
            g.FillRectangle(bufferBrush, 0, 0, this.Width * buffered, this.Height);

        using (Brush progressBrush = new SolidBrush(Color.Red))
            g.FillRectangle(progressBrush, 0, 0, this.Width * progress, this.Height);
    }

    private void SeekBar_MouseDown(object sender, MouseEventArgs e)
    {
        float newProgress = (float)e.X / this.Width;
        SetProgress(newProgress);
        Console.WriteLine($"Перемотка на {newProgress * 100}%");
    }
}
