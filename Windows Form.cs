using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    public Form1()
    {
        TextBox textBox = new TextBox { Location = new Point(100, 20), Width = 200 };
        Button btnMessage = new Button { Text = "Show Message", Location = new Point(20, 60) };
        Button btnColor = new Button { Text = "Color", Location = new Point(150, 60) };
        Button btnFont = new Button { Text = "Font", Location = new Point(250, 60) };

        btnMessage.Click += (s, e) => MessageBox.Show(textBox.Text);
        btnColor.Click += (s, e) => { using (var dlg = new ColorDialog()) { if (dlg.ShowDialog() == DialogResult.OK) textBox.ForeColor = dlg.Color; } };
        btnFont.Click += (s, e) => { using (var dlg = new FontDialog()) { if (dlg.ShowDialog() == DialogResult.OK) textBox.Font = dlg.Font; } };

        Controls.Add(textBox);
        Controls.Add(btnMessage);
        Controls.Add(btnColor);
        Controls.Add(btnFont);

        this.Text = "Simple Form";
        this.Size = new Size(400, 150);
    }

    [STAThread]
    static void Main() => Application.Run(new Form1());
}
