using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


class S05 : Form
{
    int circleSize = 10;
    int currentCircle = 0;
    int circlesCount = 20;

    public S05()
    {
        var timer = new Timer();
        timer.Interval = 500;
        timer.Tick += timer_Tick;
        timer.Start();
    }


    void timer_Tick(object sender, EventArgs e)
    {
        var radius = Math.Min(ClientSize.Width, ClientSize.Height) / 3;
        using (var graphics = CreateGraphics())
        {
            graphics.FillEllipse(
                Brushes.Black,
                (int)(ClientSize.Width / 2 + radius * Math.Cos((Math.PI*2*currentCircle) / circlesCount) - circleSize),
                (int)(ClientSize.Height / 2 + radius * Math.Sin((Math.PI*2*currentCircle) / circlesCount) - circleSize),
                2 * circleSize,
                2 * circleSize);
        }
        currentCircle++;


    }

    public static void MainX()
    {
        Application.Run(new S05());
    }
}