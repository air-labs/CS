using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


class S06 : Form
{
    int circleSize = 10;
    int currentCircle = 0;
    int circlesCount = 20;

    public S06()
    {
        var timer = new Timer();
        timer.Interval = 500;
        timer.Tick += timer_Tick;
        timer.Start();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;
        for (int i = 0; i <= currentCircle; i++)
        {
            e.Graphics.FillEllipse(
                Brushes.Black,
                (int)(ClientSize.Width / 2 + radius * Math.Cos((Math.PI * 2 * i) / circlesCount) - circleSize),
                (int)(ClientSize.Height / 2 + radius * Math.Sin((Math.PI * 2 * i) / circlesCount) - circleSize),
                2 * circleSize,
                2 * circleSize);
        }
    }

    void timer_Tick(object sender, EventArgs e)
    {
        currentCircle++;
        Invalidate();
    }

    public static void Main()
    {
        Application.Run(new S06());
    }
}