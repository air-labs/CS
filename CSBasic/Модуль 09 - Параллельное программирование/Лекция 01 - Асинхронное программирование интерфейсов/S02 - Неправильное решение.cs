using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


class S02 : Form
{
    Label label;
    Button button;
    public S02()
    {
        label = new Label();
        label.Width = ClientSize.Width;
        label.Text = "Old Value";
        Controls.Add(label);
        button=new Button();
        button.Top=label.Bottom;
        button.Width = label.Width;
        Controls.Add(button);
        button.Click += (sender, args) =>
            {
                new Action<object, EventArgs>(MakeAction).BeginInvoke(sender, args, null, null);
            };
    }

    string ExpensiveOperation()
    {
        Thread.Sleep(3000);
        return "New Value";
    }

    void MakeAction(object sender, EventArgs e)
    {
        label.Text = ExpensiveOperation();
        
    }
}