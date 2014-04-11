using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


class S05 : Form
{
    Label label;
    Button button;
    public S05()
    {
        label = new Label();
        label.Text = "Old Value";
        label.Width = ClientSize.Width;
        Controls.Add(label);
        button = new Button();
        button.Top = label.Bottom;
        button.Width = label.Width;
        Controls.Add(button);
        button.Click += MakeAction;
    }

    string ExpensiveOperation(object worker, EventArgs args)
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(300);
            (worker as BackgroundWorker).ReportProgress(i * 10);
            if ((worker as BackgroundWorker).CancellationPending) break;
        }
        return "New Value";
    }

    void MakeAction(object sender, EventArgs e)
    {
        ProgressBar bar = new ProgressBar
        {
            Width=200,
            Height=25
        };

        Button cancel=new Button
        {
            Top = 25,
            Width=200,
            Height=25,
            Text="Cancel"
        };

        var waitForm = new Form()
        {
            Text = "Wait...",
            ClientSize = new Size(200, 50),
            Controls = { bar, cancel }
        };




        var backWorker = new BackgroundWorker();
        backWorker.WorkerSupportsCancellation = true;
        backWorker.WorkerReportsProgress = true;
        string result = null;

        backWorker.DoWork += (s,a)=>
            {
                result = ExpensiveOperation(s,a);
            };

        backWorker.RunWorkerCompleted += (s, a) =>
            {
                waitForm.Close();
                label.Text = result;
            };

        backWorker.ProgressChanged += (s, a) =>
            {
                bar.Value = a.ProgressPercentage;
            };

        cancel.Click += (s, a) =>
            {
                backWorker.CancelAsync();
            };

        waitForm.Show();
        backWorker.RunWorkerAsync();
    }
}