using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


class S07 : Form
{
    Label label;
    Button button;
    public S07()
    {
        label = new Label();
        label.Width = ClientSize.Width;
        label.Text = "Old Value";
        Controls.Add(label);
        button = new Button();
        button.Top = label.Bottom;
        button.Width = label.Width;
        Controls.Add(button);
        button.Click += MakeAction;
    }

    Task<string> ExpensiveOperation()
    {
        var task = new Task<string>(() =>
            {
                Thread.Sleep(3000);
                return "New Value";
            });
        task.Start();
        return task;
    }

    async void MakeAction(object sender, EventArgs e)
    {
        label.Text = await ExpensiveOperation();
    }
}