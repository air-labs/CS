using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


class S04 : Form
{
    Label label;
    Button button;
    public S04()
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

    string ExpensiveOperation()
    {
        Thread.Sleep(3000);
        return "New Value";
    }

    void MakeAction(object sender, EventArgs e)
    {
        var backWorker = new BackgroundWorker();
        string result = null;
        backWorker.DoWork += (s,a)=>
            {
                result = ExpensiveOperation();
            };
        backWorker.RunWorkerCompleted += (s, a) =>
            {
                label.Text = result;
            };
        backWorker.RunWorkerAsync();
    }
}